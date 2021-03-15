
namespace ImageViewerApp
{
    partial class FrmViewer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuSelectImage = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSizeMode = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.PicMain = new System.Windows.Forms.PictureBox();
            this.DlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stretchimageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centerImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuSelectImage,
            this.MnuSizeMode,
            this.MnuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1089, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuSelectImage
            // 
            this.MnuSelectImage.Name = "MnuSelectImage";
            this.MnuSelectImage.Size = new System.Drawing.Size(83, 20);
            this.MnuSelectImage.Text = "이미지 선택";
            this.MnuSelectImage.Click += new System.EventHandler(this.MnuSelectImage_Click);
            // 
            // MnuSizeMode
            // 
            this.MnuSizeMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.stretchimageToolStripMenuItem,
            this.autoSizeToolStripMenuItem,
            this.centerImageToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.MnuSizeMode.Name = "MnuSizeMode";
            this.MnuSizeMode.Size = new System.Drawing.Size(72, 20);
            this.MnuSizeMode.Text = "SizeMode";
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(43, 20);
            this.MnuExit.Text = "종료";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // PicMain
            // 
            this.PicMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicMain.Location = new System.Drawing.Point(0, 24);
            this.PicMain.Name = "PicMain";
            this.PicMain.Size = new System.Drawing.Size(1089, 544);
            this.PicMain.TabIndex = 1;
            this.PicMain.TabStop = false;
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // stretchimageToolStripMenuItem
            // 
            this.stretchimageToolStripMenuItem.Name = "stretchimageToolStripMenuItem";
            this.stretchimageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stretchimageToolStripMenuItem.Text = "Stretchimage";
            this.stretchimageToolStripMenuItem.Click += new System.EventHandler(this.stretchimageToolStripMenuItem_Click);
            // 
            // autoSizeToolStripMenuItem
            // 
            this.autoSizeToolStripMenuItem.Name = "autoSizeToolStripMenuItem";
            this.autoSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.autoSizeToolStripMenuItem.Text = "AutoSize";
            this.autoSizeToolStripMenuItem.Click += new System.EventHandler(this.autoSizeToolStripMenuItem_Click);
            // 
            // centerImageToolStripMenuItem
            // 
            this.centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            this.centerImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.centerImageToolStripMenuItem.Text = "CenterImage";
            this.centerImageToolStripMenuItem.Click += new System.EventHandler(this.centerImageToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // FrmViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 568);
            this.Controls.Add(this.PicMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmViewer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmViewer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuSelectImage;
        private System.Windows.Forms.ToolStripMenuItem MnuSizeMode;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.PictureBox PicMain;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stretchimageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centerImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog DlgOpenImage;
    }
}

