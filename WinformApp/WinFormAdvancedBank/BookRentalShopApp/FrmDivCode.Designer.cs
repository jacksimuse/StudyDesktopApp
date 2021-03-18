
namespace BookRentalShopApp
{
    partial class FrmDivCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GrbDetail = new System.Windows.Forms.GroupBox();
            this.TxtNames = new MetroFramework.Controls.MetroTextBox();
            this.TxtDivision = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.GrbDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbDetail
            // 
            this.GrbDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrbDetail.Controls.Add(this.TxtNames);
            this.GrbDetail.Controls.Add(this.TxtDivision);
            this.GrbDetail.Controls.Add(this.metroLabel2);
            this.GrbDetail.Controls.Add(this.metroLabel1);
            this.GrbDetail.Controls.Add(this.BtnSave);
            this.GrbDetail.Controls.Add(this.BtnNew);
            this.GrbDetail.Controls.Add(this.BtnDelete);
            this.GrbDetail.Location = new System.Drawing.Point(437, 63);
            this.GrbDetail.Name = "GrbDetail";
            this.GrbDetail.Size = new System.Drawing.Size(350, 364);
            this.GrbDetail.TabIndex = 0;
            this.GrbDetail.TabStop = false;
            this.GrbDetail.Text = "상세";
            // 
            // TxtNames
            // 
            // 
            // 
            // 
            this.TxtNames.CustomButton.Image = null;
            this.TxtNames.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.TxtNames.CustomButton.Name = "";
            this.TxtNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNames.CustomButton.TabIndex = 1;
            this.TxtNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNames.CustomButton.UseSelectable = true;
            this.TxtNames.CustomButton.Visible = false;
            this.TxtNames.Lines = new string[0];
            this.TxtNames.Location = new System.Drawing.Point(99, 93);
            this.TxtNames.MaxLength = 32767;
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.PasswordChar = '\0';
            this.TxtNames.PromptText = "이름";
            this.TxtNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNames.SelectedText = "";
            this.TxtNames.SelectionLength = 0;
            this.TxtNames.SelectionStart = 0;
            this.TxtNames.ShortcutsEnabled = true;
            this.TxtNames.Size = new System.Drawing.Size(240, 23);
            this.TxtNames.TabIndex = 7;
            this.TxtNames.UseSelectable = true;
            this.TxtNames.WaterMark = "이름";
            this.TxtNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNames.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtDivision
            // 
            // 
            // 
            // 
            this.TxtDivision.CustomButton.Image = null;
            this.TxtDivision.CustomButton.Location = new System.Drawing.Point(218, 1);
            this.TxtDivision.CustomButton.Name = "";
            this.TxtDivision.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtDivision.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDivision.CustomButton.TabIndex = 1;
            this.TxtDivision.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDivision.CustomButton.UseSelectable = true;
            this.TxtDivision.CustomButton.Visible = false;
            this.TxtDivision.Lines = new string[0];
            this.TxtDivision.Location = new System.Drawing.Point(99, 41);
            this.TxtDivision.MaxLength = 32767;
            this.TxtDivision.Name = "TxtDivision";
            this.TxtDivision.PasswordChar = '\0';
            this.TxtDivision.PromptText = "구분코드";
            this.TxtDivision.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDivision.SelectedText = "";
            this.TxtDivision.SelectionLength = 0;
            this.TxtDivision.SelectionStart = 0;
            this.TxtDivision.ShortcutsEnabled = true;
            this.TxtDivision.Size = new System.Drawing.Size(240, 23);
            this.TxtDivision.TabIndex = 6;
            this.TxtDivision.UseSelectable = true;
            this.TxtDivision.WaterMark = "구분코드";
            this.TxtDivision.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDivision.WaterMarkFont = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(49, 97);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(44, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "이름 :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(21, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(72, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "구분코드 :";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(257, 326);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 2;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(171, 326);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 1;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(85, 326);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(23, 64);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(392, 363);
            this.DgvData.TabIndex = 1;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            // 
            // FrmDivCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.GrbDetail);
            this.Name = "FrmDivCode";
            this.Text = "책 구분코드 관리";
            this.Load += new System.EventHandler(this.FrmDivCode_Load);
            this.Resize += new System.EventHandler(this.FrmDivCode_Resize);
            this.GrbDetail.ResumeLayout(false);
            this.GrbDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbDetail;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroTextBox TxtNames;
        private MetroFramework.Controls.MetroTextBox TxtDivision;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private System.Windows.Forms.DataGridView DgvData;
    }
}