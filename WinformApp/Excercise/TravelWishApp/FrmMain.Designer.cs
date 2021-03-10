
namespace TravelWishApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.LsbWishCountry = new System.Windows.Forms.CheckedListBox();
            this.LsbResult = new System.Windows.Forms.ListBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnAddAll = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.BtnRemoveAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LsbWishCountry
            // 
            this.LsbWishCountry.FormattingEnabled = true;
            this.LsbWishCountry.Location = new System.Drawing.Point(5, 12);
            this.LsbWishCountry.Name = "LsbWishCountry";
            this.LsbWishCountry.Size = new System.Drawing.Size(194, 228);
            this.LsbWishCountry.TabIndex = 0;
            // 
            // LsbResult
            // 
            this.LsbResult.FormattingEnabled = true;
            this.LsbResult.ItemHeight = 12;
            this.LsbResult.Location = new System.Drawing.Point(286, 12);
            this.LsbResult.Name = "LsbResult";
            this.LsbResult.Size = new System.Drawing.Size(194, 232);
            this.LsbResult.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(205, 76);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = ">";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnAddAll
            // 
            this.BtnAddAll.Location = new System.Drawing.Point(205, 105);
            this.BtnAddAll.Name = "BtnAddAll";
            this.BtnAddAll.Size = new System.Drawing.Size(75, 23);
            this.BtnAddAll.TabIndex = 3;
            this.BtnAddAll.Text = ">>";
            this.BtnAddAll.UseVisualStyleBackColor = true;
            this.BtnAddAll.Click += new System.EventHandler(this.BtnAddAll_Click);
            // 
            // BtnRemove
            // 
            this.BtnRemove.Location = new System.Drawing.Point(205, 134);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(75, 23);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "<";
            this.BtnRemove.UseVisualStyleBackColor = true;
            this.BtnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // BtnRemoveAll
            // 
            this.BtnRemoveAll.Location = new System.Drawing.Point(205, 163);
            this.BtnRemoveAll.Name = "BtnRemoveAll";
            this.BtnRemoveAll.Size = new System.Drawing.Size(75, 24);
            this.BtnRemoveAll.TabIndex = 5;
            this.BtnRemoveAll.Text = "<<";
            this.BtnRemoveAll.UseVisualStyleBackColor = true;
            this.BtnRemoveAll.Click += new System.EventHandler(this.BtnRemoveAll_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 247);
            this.Controls.Add(this.BtnRemoveAll);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.BtnAddAll);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LsbResult);
            this.Controls.Add(this.LsbWishCountry);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Wish List";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox LsbWishCountry;
        private System.Windows.Forms.ListBox LsbResult;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnAddAll;
        private System.Windows.Forms.Button BtnRemove;
        private System.Windows.Forms.Button BtnRemoveAll;
    }
}

