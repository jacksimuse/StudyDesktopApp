
namespace ColorChangeApp
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
            this.PnlResult = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.TrbRed = new System.Windows.Forms.TrackBar();
            this.TrbGreen = new System.Windows.Forms.TrackBar();
            this.TrbBlue = new System.Windows.Forms.TrackBar();
            this.TxtRed = new System.Windows.Forms.TextBox();
            this.TxtGreen = new System.Windows.Forms.TextBox();
            this.TxtBlue = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TrbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlResult
            // 
            this.PnlResult.BackColor = System.Drawing.Color.Black;
            this.PnlResult.Location = new System.Drawing.Point(91, 30);
            this.PnlResult.Name = "PnlResult";
            this.PnlResult.Size = new System.Drawing.Size(579, 232);
            this.PnlResult.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Blue";
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(723, 30);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(29, 23);
            this.BtnColor.TabIndex = 4;
            this.BtnColor.Text = "...";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(723, 68);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(29, 23);
            this.BtnOpen.TabIndex = 5;
            this.BtnOpen.Text = "...";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(723, 107);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(29, 23);
            this.BtnSave.TabIndex = 6;
            this.BtnSave.Text = "...";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TrbRed
            // 
            this.TrbRed.Location = new System.Drawing.Point(157, 268);
            this.TrbRed.Maximum = 255;
            this.TrbRed.Name = "TrbRed";
            this.TrbRed.Size = new System.Drawing.Size(374, 45);
            this.TrbRed.TabIndex = 7;
            this.TrbRed.TickFrequency = 5;
            this.TrbRed.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // TrbGreen
            // 
            this.TrbGreen.Location = new System.Drawing.Point(157, 315);
            this.TrbGreen.Maximum = 255;
            this.TrbGreen.Name = "TrbGreen";
            this.TrbGreen.Size = new System.Drawing.Size(374, 45);
            this.TrbGreen.TabIndex = 8;
            this.TrbGreen.TickFrequency = 5;
            this.TrbGreen.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // TrbBlue
            // 
            this.TrbBlue.Location = new System.Drawing.Point(157, 366);
            this.TrbBlue.Maximum = 255;
            this.TrbBlue.Name = "TrbBlue";
            this.TrbBlue.Size = new System.Drawing.Size(374, 45);
            this.TrbBlue.TabIndex = 9;
            this.TrbBlue.TickFrequency = 5;
            this.TrbBlue.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // TxtRed
            // 
            this.TxtRed.Location = new System.Drawing.Point(550, 274);
            this.TxtRed.Name = "TxtRed";
            this.TxtRed.ReadOnly = true;
            this.TxtRed.Size = new System.Drawing.Size(110, 21);
            this.TxtRed.TabIndex = 10;
            this.TxtRed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtGreen
            // 
            this.TxtGreen.Location = new System.Drawing.Point(550, 319);
            this.TxtGreen.Name = "TxtGreen";
            this.TxtGreen.ReadOnly = true;
            this.TxtGreen.Size = new System.Drawing.Size(110, 21);
            this.TxtGreen.TabIndex = 11;
            this.TxtGreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtBlue
            // 
            this.TxtBlue.Location = new System.Drawing.Point(551, 368);
            this.TxtBlue.Name = "TxtBlue";
            this.TxtBlue.ReadOnly = true;
            this.TxtBlue.Size = new System.Drawing.Size(110, 21);
            this.TxtBlue.TabIndex = 12;
            this.TxtBlue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 450);
            this.Controls.Add(this.TxtBlue);
            this.Controls.Add(this.TxtGreen);
            this.Controls.Add(this.TxtRed);
            this.Controls.Add(this.TrbBlue);
            this.Controls.Add(this.TrbGreen);
            this.Controls.Add(this.TrbRed);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PnlResult);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "RGB Color Scroller";
            ((System.ComponentModel.ISupportInitialize)(this.TrbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.TrackBar TrbRed;
        private System.Windows.Forms.TrackBar TrbGreen;
        private System.Windows.Forms.TrackBar TrbBlue;
        private System.Windows.Forms.TextBox TxtRed;
        private System.Windows.Forms.TextBox TxtGreen;
        private System.Windows.Forms.TextBox TxtBlue;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

