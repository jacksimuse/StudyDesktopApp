﻿
namespace StudyHistoryApp
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
            this.PcbPhoto = new System.Windows.Forms.PictureBox();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TrvList = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.PcbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // PcbPhoto
            // 
            this.PcbPhoto.Location = new System.Drawing.Point(353, 12);
            this.PcbPhoto.Name = "PcbPhoto";
            this.PcbPhoto.Size = new System.Drawing.Size(255, 222);
            this.PcbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PcbPhoto.TabIndex = 0;
            this.PcbPhoto.TabStop = false;
            // 
            // TxtDescription
            // 
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescription.Location = new System.Drawing.Point(353, 240);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescription.Size = new System.Drawing.Size(255, 133);
            this.TxtDescription.TabIndex = 1;
            // 
            // TrvList
            // 
            this.TrvList.Location = new System.Drawing.Point(18, 18);
            this.TrvList.Name = "TrvList";
            this.TrvList.Size = new System.Drawing.Size(329, 355);
            this.TrvList.TabIndex = 2;
            this.TrvList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TrvList_AfterSelect);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 385);
            this.Controls.Add(this.TrvList);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.PcbPhoto);
            this.Name = "FrmMain";
            this.Text = "영국군주 리스트";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PcbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PcbPhoto;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TreeView TrvList;
    }
}

