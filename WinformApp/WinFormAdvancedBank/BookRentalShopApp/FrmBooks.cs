using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookRentalShopApp
{
    public partial class FrmBooks : MetroForm
    {
        #region 전역변수 영역

        public bool IsNew = false; // false (수정) / true(신규)

        #endregion

        #region 이벤트 영역

        public FrmBooks()
        {
            InitializeComponent();
        }
        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            IsNew = true; // 신규 초기화
            InitCboData(); // 콤보박스 들어가는 데이터 초기화
            RefreshData(); // 테이블 조회
        }

        

        private void FrmDivCode_Resize(object sender, EventArgs e)
        {
            DgvData.Height = this.ClientRectangle.Height - 90;
            GrbDetail.Height = this.ClientRectangle.Height - 90;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation 체크
            if (CheckValidation() == false) return;

            SaveData();
            RefreshData();
            ClearInputs();
        }
        private void BtnNew_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Validation 체크
            if (CheckValidation() == false) return;
            // 삭제 질문
            if (MetroMessageBox.Show(this, "삭제하시겠습니까?", "삭제",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DeleteData();
            RefreshData();
            ClearInputs();
        }
        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1) // 선택된 값이 존재하면
            {
                var selData = DgvData.Rows[e.RowIndex];
                TxtIdx.Text = selData.Cells[0].Value.ToString();
                TxtAuthor.Text = selData.Cells[1].Value.ToString();
                CboDivision.SelectedItem = selData.Cells[2].Value;

                TxtNames.Text = selData.Cells[3].Value.ToString();
                // TxtMobile.Text = selData.Cells[4].Value.ToString();
                TxtISBN.Text = selData.Cells[5].Value.ToString();
                TxtPrice.Text = selData.Cells[6].Value.ToString();

                TxtIdx.ReadOnly = true;

                IsNew = false; // 수정
            }
        }

        #endregion

        #region 커스텀 메서드 영역

        private void InitCboData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    var query = "SELECT Division, Names FROM dbo.divtbl";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    var temp = new Dictionary<string, string>();
                    while (reader.Read())
                    {
                        temp.Add(reader[0].ToString(), reader[1].ToString()); // B001, 공포/스릴러
                    }
                    CboDivision.DataSource = new BindingSource(temp, "divtbl");
                    CboDivision.DisplayMember = "Value";
                    CboDivision.ValueMember = "Key";
                    CboDivision.SelectedIndex = -1;
                }
            }
            catch { }
        }

        /// <summary>
        /// 입력 수정
        /// </summary>
        private void RefreshData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();

                    var query = @"SELECT b.Idx
                                       , b.Author
                                       , b.Division
                                       , b.Names as DivName
                                       , b.ReleaseDate
                                       , b.ISBN
                                       , b.Price
                                       , b.Descriptions
                                    FROM dbo.bookstbl as b
                                   INNER JOIN dbo.divtbl as d
                                      ON b.Division = d.Division ";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "bookstbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "bookstbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 데이터그리드뷰 컬럼(Division) 화면에서 안보이게
            var column = DgvData.Columns[2]; // Division 컬럼
            column.Visible = false;
        }
        private void SaveData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";

                    if (IsNew == true) // INSERT
                    {
                        query = @"INSERT INTO [dbo].[bookstbl]
                                        ([Author]
                                       , [Division]
                                       , [Names]
                                       , [ReleaseDate]
                                       , [ISBN]
                                       , [Price]
                                       , [Descriptions])

                                  VALUES
                                        (@Author
                                       , @Division
                                       , @Names
                                       , @ReleaseDate
                                       , @ISBN
                                       , @Price
                                       , @Descriptions ";
                    }
                    else // UPDATE
                    {
                        query = @"UPDATE [dbo].[membertbl]
                                     SET [Names] = @Names
                                       , [Levels] = @Levels
                                       , [Addr] = @Addr
                                       , [Mobile] = @Mobile
                                       , [Email] = @Email
                                       , [userID] = @userID
                                       , [passwords] = @passwords
                                   WHERE Idx = @Idx ";
                    }
                    cmd.CommandText = query;

                    var pNames = new SqlParameter("@Names", SqlDbType.NVarChar, 50);
                    pNames.Value = TxtAuthor.Text;
                    cmd.Parameters.Add(pNames);

                    var pLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                    pLevels.Value = CboDivision.SelectedItem.ToString();
                    cmd.Parameters.Add(pLevels);

                    var pAddr = new SqlParameter("@Addr", SqlDbType.NVarChar, 100);
                    pAddr.Value = TxtNames.Text;
                    cmd.Parameters.Add(pAddr);

                    var pMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                    // pMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(pMobile);

                    var pEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                    pEmail.Value = TxtISBN.Text;
                    cmd.Parameters.Add(pEmail);

                    var pUserId = new SqlParameter("@userID", SqlDbType.VarChar, 20);
                    pUserId.Value = TxtPrice.Text;
                    cmd.Parameters.Add(pUserId);

                    var pPasswords = new SqlParameter("@password", SqlDbType.VarChar, 100);
                    pPasswords.Value = TxtDescriptions.Text;
                    cmd.Parameters.Add(pPasswords);

                    if (IsNew == false) // Update 일때만 처리
                    {
                        var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                        pIdx.Value = TxtIdx.Text;
                        cmd.Parameters.Add(pIdx);
                    }

                    var reuslt = cmd.ExecuteNonQuery();
                    if (reuslt == 1)
                    {
                        MetroMessageBox.Show(this, "저장 성공", "저장",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "저장 실패", "저장",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            TxtIdx.Text = TxtAuthor.Text = "";
            // TxtMobile.Text = TxtNames.Text = TxtISBN.Text = "";
            TxtPrice.Text = TxtDescriptions.Text = "";
            CboDivision.SelectedItem = -1;
            TxtIdx.ReadOnly = false;
            IsNew = true;
        }
        /// <summary>
        /// 삭제처리 프로세스
        /// </summary>
        private void DeleteData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Helper.Common.ConnString))
                {
                    if (conn.State == ConnectionState.Closed) conn.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    var query = "";

                    query = "DELETE FROM [dbo].[membertbl] " +
                                " WHERE [Idx] = @Idx ";
                    cmd.CommandText = query;

                    var pIdx = new SqlParameter("@Idx", SqlDbType.Int);
                    pIdx.Value = TxtAuthor.Text;
                    cmd.Parameters.Add(pIdx);

                    var reuslt = cmd.ExecuteNonQuery();
                    if (reuslt == 1)
                    {
                        MetroMessageBox.Show(this, "삭제 성공", "삭제",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "삭제 실패", "삭제",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 입력값 유효성 체크 메서드
        /// </summary>
        /// <returns></returns>
        private bool CheckValidation()
        {
            if (string.IsNullOrEmpty(TxtAuthor.Text) ||
                string.IsNullOrEmpty(TxtNames.Text) || 
                //string.IsNullOrEmpty(TxtMobile.Text) ||
                string.IsNullOrEmpty(TxtISBN.Text) || CboDivision.SelectedIndex == -1 ||
                string.IsNullOrEmpty(TxtPrice.Text) || string.IsNullOrEmpty(TxtDescriptions.Text))
            {
                MetroMessageBox.Show(this, "빈값은 처리할 수 없습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        #endregion

    }
}