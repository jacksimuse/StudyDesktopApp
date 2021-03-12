
namespace MyNotePadApp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.편집EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtMain = new System.Windows.Forms.RichTextBox();
            this.DlgOpenText = new System.Windows.Forms.OpenFileDialog();
            this.DlgSaveText = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.편집EToolStripMenuItem,
            this.도움말HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuNewFile,
            this.MnuOpenFile,
            this.MnuSaveFile,
            this.toolStripMenuItem1,
            this.MnuExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // MnuNewFile
            // 
            this.MnuNewFile.Name = "MnuNewFile";
            this.MnuNewFile.Size = new System.Drawing.Size(180, 22);
            this.MnuNewFile.Text = "새로만들기(&N)";
            this.MnuNewFile.Click += new System.EventHandler(this.MnuNewFile_Click);
            // 
            // MnuOpenFile
            // 
            this.MnuOpenFile.Name = "MnuOpenFile";
            this.MnuOpenFile.Size = new System.Drawing.Size(180, 22);
            this.MnuOpenFile.Text = "열기(&O)";
            this.MnuOpenFile.Click += new System.EventHandler(this.MnuOpenFile_Click);
            // 
            // MnuSaveFile
            // 
            this.MnuSaveFile.Name = "MnuSaveFile";
            this.MnuSaveFile.Size = new System.Drawing.Size(180, 22);
            this.MnuSaveFile.Text = "저장(&S)";
            this.MnuSaveFile.Click += new System.EventHandler(this.MnuSaveFile_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(180, 22);
            this.MnuExit.Text = "종료(&X)";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // 편집EToolStripMenuItem
            // 
            this.편집EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuCopy,
            this.MnuPaste});
            this.편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            this.편집EToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.편집EToolStripMenuItem.Text = "편집(&E)";
            // 
            // MnuCopy
            // 
            this.MnuCopy.Name = "MnuCopy";
            this.MnuCopy.Size = new System.Drawing.Size(138, 22);
            this.MnuCopy.Text = "복사하기(&C)";
            this.MnuCopy.Click += new System.EventHandler(this.MnuCopy_Click);
            // 
            // MnuPaste
            // 
            this.MnuPaste.Name = "MnuPaste";
            this.MnuPaste.Size = new System.Drawing.Size(138, 22);
            this.MnuPaste.Text = "붙여넣기(&P)";
            this.MnuPaste.Click += new System.EventHandler(this.MnuPaste_Click);
            // 
            // 도움말HToolStripMenuItem
            // 
            this.도움말HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAbout});
            this.도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            this.도움말HToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.도움말HToolStripMenuItem.Text = "도움말(&H)";
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(166, 22);
            this.MnuAbout.Text = "프로그램 정보(&A)";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // TxtMain
            // 
            this.TxtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtMain.Location = new System.Drawing.Point(0, 24);
            this.TxtMain.Name = "TxtMain";
            this.TxtMain.Size = new System.Drawing.Size(800, 426);
            this.TxtMain.TabIndex = 1;
            this.TxtMain.Text = "";
            this.TxtMain.TextChanged += new System.EventHandler(this.TxtMain_TextChanged);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "내 메모장";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuNewFile;
        private System.Windows.Forms.ToolStripMenuItem MnuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem MnuSaveFile;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem 편집EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuCopy;
        private System.Windows.Forms.ToolStripMenuItem MnuPaste;
        private System.Windows.Forms.ToolStripMenuItem 도움말HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.RichTextBox TxtMain;
        private System.Windows.Forms.OpenFileDialog DlgOpenText;
        private System.Windows.Forms.SaveFileDialog DlgSaveText;
    }
}

