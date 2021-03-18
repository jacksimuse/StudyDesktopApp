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
    public partial class FrmMember : MetroForm
    {
        #region 전역변수 영역

        public bool IsNew = false; // false (수정) / true(신규)

        #endregion

        #region 이벤트 영역

        public FrmMember()
        {
            InitializeComponent();
        }
        private void FrmDivCode_Load(object sender, EventArgs e)
        {
            IsNew = true; // 신규 초기화
            RefreshData();
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
                TxtNames.Text = selData.Cells[1].Value.ToString();
                CboLevels.SelectedItem = selData.Cells[2].Value;

                TxtAddr.Text = selData.Cells[3].Value.ToString();
                TxtMobile.Text = selData.Cells[4].Value.ToString();
                TxtEmail.Text = selData.Cells[5].Value.ToString();
                TxtUserId.Text = selData.Cells[6].Value.ToString();

                TxtIdx.ReadOnly = true;

                IsNew = false; // 수정
            }
        }

        #endregion

        #region 커스텀 메서드 영역
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

                    var query = @"SELECT [Idx]
                                      , [Names]
                                      , [Levels]
                                      , [Addr]
                                      , [Mobile]
                                      , [Email]
                                      , [userID]
                                      , [lastLoginDt]
                                      , [loginIpAddr]
                                   FROM [dbo].[membertbl]";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds, "membertbl");

                    DgvData.DataSource = ds;
                    DgvData.DataMember = "membertbl";
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, $"예외발생 : {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                        query = @"INSERT INTO [dbo].[membertbl]
                                       ( [Names]
                                       , [Levels]
                                       , [Addr]
                                       , [Mobile]
                                       , [Email]
                                       , [userID]
                                       , [passwords])

                                 VALUES
                                       ( @Names
                                       , @Levels
                                       , @Addr
                                       , @Mobile
                                       , @Email
                                       , @userID
                                       , @passwords) ";
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
                    pNames.Value = TxtNames.Text;
                    cmd.Parameters.Add(pNames);

                    var pLevels = new SqlParameter("@Levels", SqlDbType.Char, 1);
                    pLevels.Value = CboLevels.SelectedItem.ToString();
                    cmd.Parameters.Add(pLevels);

                    var pAddr = new SqlParameter("@Addr", SqlDbType.NVarChar, 100);
                    pAddr.Value = TxtAddr.Text;
                    cmd.Parameters.Add(pAddr);

                    var pMobile = new SqlParameter("@Mobile", SqlDbType.VarChar, 13);
                    pMobile.Value = TxtMobile.Text;
                    cmd.Parameters.Add(pMobile);

                    var pEmail = new SqlParameter("@Email", SqlDbType.VarChar, 50);
                    pEmail.Value = TxtEmail.Text;
                    cmd.Parameters.Add(pEmail);

                    var pUserId = new SqlParameter("@userID", SqlDbType.VarChar, 20);
                    pUserId.Value = TxtUserId.Text;
                    cmd.Parameters.Add(pUserId);

                    var pPasswords = new SqlParameter("@passwords", SqlDbType.VarChar, 100);
                    pPasswords.Value = TxtPasswords.Text;
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
            TxtIdx.Text = TxtNames.Text = "";
            TxtMobile.Text = TxtAddr.Text = TxtEmail.Text = "";
            TxtUserId.Text = TxtPasswords.Text = "";
            CboLevels.SelectedIndex = -1;
            TxtIdx.ReadOnly = true;
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
                    pIdx.Value = TxtIdx.Text;
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
            if (string.IsNullOrEmpty(TxtNames.Text) ||
                string.IsNullOrEmpty(TxtAddr.Text) || string.IsNullOrEmpty(TxtMobile.Text) ||
                string.IsNullOrEmpty(TxtEmail.Text) || CboLevels.SelectedIndex == -1 ||
                string.IsNullOrEmpty(TxtUserId.Text) )
            {
                MetroMessageBox.Show(this, "빈값은 처리할 수 없습니다", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        #endregion

    }
}