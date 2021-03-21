
namespace WinCalculatorApp
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
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.BtnMC = new System.Windows.Forms.Button();
            this.BtnCE = new System.Windows.Forms.Button();
            this.BtnMR = new System.Windows.Forms.Button();
            this.BtnMPlus = new System.Windows.Forms.Button();
            this.BtnMMinus = new System.Windows.Forms.Button();
            this.BtnMS = new System.Windows.Forms.Button();
            this.BtnPercent = new System.Windows.Forms.Button();
            this.BtnSqrt = new System.Windows.Forms.Button();
            this.BtnSqr = new System.Windows.Forms.Button();
            this.BtnRecip = new System.Windows.Forms.Button();
            this.BtnC = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnDivide = new System.Windows.Forms.Button();
            this.Btn7 = new System.Windows.Forms.Button();
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn9 = new System.Windows.Forms.Button();
            this.BtnMultiple = new System.Windows.Forms.Button();
            this.Btn4 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn6 = new System.Windows.Forms.Button();
            this.BtnMinus = new System.Windows.Forms.Button();
            this.Btn1 = new System.Windows.Forms.Button();
            this.Btn2 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.BtnPlus = new System.Windows.Forms.Button();
            this.BtnSign = new System.Windows.Forms.Button();
            this.Btn0 = new System.Windows.Forms.Button();
            this.BtnDot = new System.Windows.Forms.Button();
            this.BtnEqual = new System.Windows.Forms.Button();
            this.TxtExp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtResult
            // 
            this.TxtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtResult.Font = new System.Drawing.Font("궁서체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtResult.Location = new System.Drawing.Point(0, 52);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(262, 28);
            this.TxtResult.TabIndex = 0;
            this.TxtResult.Text = "0";
            this.TxtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnMC
            // 
            this.BtnMC.FlatAppearance.BorderSize = 0;
            this.BtnMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMC.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMC.Location = new System.Drawing.Point(7, 86);
            this.BtnMC.Name = "BtnMC";
            this.BtnMC.Size = new System.Drawing.Size(50, 35);
            this.BtnMC.TabIndex = 2;
            this.BtnMC.Text = "MC";
            this.BtnMC.UseVisualStyleBackColor = true;
            this.BtnMC.Click += new System.EventHandler(this.BtnMC_Click);
            // 
            // BtnCE
            // 
            this.BtnCE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnCE.FlatAppearance.BorderSize = 0;
            this.BtnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCE.Location = new System.Drawing.Point(0, 168);
            this.BtnCE.Name = "BtnCE";
            this.BtnCE.Size = new System.Drawing.Size(69, 50);
            this.BtnCE.TabIndex = 3;
            this.BtnCE.Text = "CE";
            this.BtnCE.UseVisualStyleBackColor = false;
            // 
            // BtnMR
            // 
            this.BtnMR.FlatAppearance.BorderSize = 0;
            this.BtnMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMR.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMR.Location = new System.Drawing.Point(57, 86);
            this.BtnMR.Name = "BtnMR";
            this.BtnMR.Size = new System.Drawing.Size(50, 35);
            this.BtnMR.TabIndex = 2;
            this.BtnMR.Text = "MR";
            this.BtnMR.UseVisualStyleBackColor = true;
            this.BtnMR.Click += new System.EventHandler(this.BtnMR_Click);
            // 
            // BtnMPlus
            // 
            this.BtnMPlus.FlatAppearance.BorderSize = 0;
            this.BtnMPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMPlus.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMPlus.Location = new System.Drawing.Point(107, 86);
            this.BtnMPlus.Name = "BtnMPlus";
            this.BtnMPlus.Size = new System.Drawing.Size(50, 35);
            this.BtnMPlus.TabIndex = 2;
            this.BtnMPlus.Text = "M+";
            this.BtnMPlus.UseVisualStyleBackColor = true;
            this.BtnMPlus.Click += new System.EventHandler(this.BtnMPlus_Click);
            // 
            // BtnMMinus
            // 
            this.BtnMMinus.FlatAppearance.BorderSize = 0;
            this.BtnMMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMMinus.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMMinus.Location = new System.Drawing.Point(157, 86);
            this.BtnMMinus.Name = "BtnMMinus";
            this.BtnMMinus.Size = new System.Drawing.Size(50, 35);
            this.BtnMMinus.TabIndex = 2;
            this.BtnMMinus.Text = "M-";
            this.BtnMMinus.UseVisualStyleBackColor = true;
            this.BtnMMinus.Click += new System.EventHandler(this.BtnMMinus_Click);
            // 
            // BtnMS
            // 
            this.BtnMS.FlatAppearance.BorderSize = 0;
            this.BtnMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMS.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnMS.Location = new System.Drawing.Point(207, 86);
            this.BtnMS.Name = "BtnMS";
            this.BtnMS.Size = new System.Drawing.Size(50, 35);
            this.BtnMS.TabIndex = 2;
            this.BtnMS.Text = "MS";
            this.BtnMS.UseVisualStyleBackColor = true;
            this.BtnMS.Click += new System.EventHandler(this.BtnMS_Click);
            // 
            // BtnPercent
            // 
            this.BtnPercent.FlatAppearance.BorderSize = 0;
            this.BtnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPercent.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnPercent.Location = new System.Drawing.Point(7, 127);
            this.BtnPercent.Name = "BtnPercent";
            this.BtnPercent.Size = new System.Drawing.Size(62, 35);
            this.BtnPercent.TabIndex = 2;
            this.BtnPercent.Text = "%";
            this.BtnPercent.UseVisualStyleBackColor = true;
            // 
            // BtnSqrt
            // 
            this.BtnSqrt.FlatAppearance.BorderSize = 0;
            this.BtnSqrt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSqrt.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSqrt.Location = new System.Drawing.Point(69, 127);
            this.BtnSqrt.Name = "BtnSqrt";
            this.BtnSqrt.Size = new System.Drawing.Size(62, 35);
            this.BtnSqrt.TabIndex = 2;
            this.BtnSqrt.Text = "√";
            this.BtnSqrt.UseVisualStyleBackColor = true;
            // 
            // BtnSqr
            // 
            this.BtnSqr.FlatAppearance.BorderSize = 0;
            this.BtnSqr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSqr.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnSqr.Location = new System.Drawing.Point(131, 127);
            this.BtnSqr.Name = "BtnSqr";
            this.BtnSqr.Size = new System.Drawing.Size(62, 35);
            this.BtnSqr.TabIndex = 2;
            this.BtnSqr.Text = "x²";
            this.BtnSqr.UseVisualStyleBackColor = true;
            // 
            // BtnRecip
            // 
            this.BtnRecip.FlatAppearance.BorderSize = 0;
            this.BtnRecip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRecip.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnRecip.Location = new System.Drawing.Point(193, 127);
            this.BtnRecip.Name = "BtnRecip";
            this.BtnRecip.Size = new System.Drawing.Size(62, 35);
            this.BtnRecip.TabIndex = 2;
            this.BtnRecip.Text = "1/x";
            this.BtnRecip.UseVisualStyleBackColor = true;
            // 
            // BtnC
            // 
            this.BtnC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnC.FlatAppearance.BorderSize = 0;
            this.BtnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnC.Location = new System.Drawing.Point(68, 168);
            this.BtnC.Name = "BtnC";
            this.BtnC.Size = new System.Drawing.Size(69, 50);
            this.BtnC.TabIndex = 3;
            this.BtnC.Text = "C";
            this.BtnC.UseVisualStyleBackColor = false;
            this.BtnC.Click += new System.EventHandler(this.BtnC_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(136, 168);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(69, 50);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "⌫";
            this.BtnDelete.UseVisualStyleBackColor = false;
            // 
            // BtnDivide
            // 
            this.BtnDivide.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDivide.FlatAppearance.BorderSize = 0;
            this.BtnDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDivide.Location = new System.Drawing.Point(198, 170);
            this.BtnDivide.Name = "BtnDivide";
            this.BtnDivide.Size = new System.Drawing.Size(69, 50);
            this.BtnDivide.TabIndex = 3;
            this.BtnDivide.Text = "÷";
            this.BtnDivide.UseVisualStyleBackColor = false;
            this.BtnDivide.Click += new System.EventHandler(this.BtnOP_Click);
            // 
            // Btn7
            // 
            this.Btn7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn7.FlatAppearance.BorderSize = 0;
            this.Btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn7.Location = new System.Drawing.Point(0, 213);
            this.Btn7.Name = "Btn7";
            this.Btn7.Size = new System.Drawing.Size(69, 50);
            this.Btn7.TabIndex = 3;
            this.Btn7.Text = "7";
            this.Btn7.UseVisualStyleBackColor = false;
            this.Btn7.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn8
            // 
            this.Btn8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn8.FlatAppearance.BorderSize = 0;
            this.Btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn8.Location = new System.Drawing.Point(68, 213);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(69, 50);
            this.Btn8.TabIndex = 3;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = false;
            this.Btn8.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn9
            // 
            this.Btn9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn9.FlatAppearance.BorderSize = 0;
            this.Btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn9.Location = new System.Drawing.Point(136, 213);
            this.Btn9.Name = "Btn9";
            this.Btn9.Size = new System.Drawing.Size(69, 50);
            this.Btn9.TabIndex = 3;
            this.Btn9.Text = "9";
            this.Btn9.UseVisualStyleBackColor = false;
            this.Btn9.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMultiple
            // 
            this.BtnMultiple.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMultiple.FlatAppearance.BorderSize = 0;
            this.BtnMultiple.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMultiple.Location = new System.Drawing.Point(204, 213);
            this.BtnMultiple.Name = "BtnMultiple";
            this.BtnMultiple.Size = new System.Drawing.Size(69, 50);
            this.BtnMultiple.TabIndex = 3;
            this.BtnMultiple.Text = "×";
            this.BtnMultiple.UseVisualStyleBackColor = false;
            this.BtnMultiple.Click += new System.EventHandler(this.BtnOP_Click);
            // 
            // Btn4
            // 
            this.Btn4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn4.FlatAppearance.BorderSize = 0;
            this.Btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn4.Location = new System.Drawing.Point(0, 258);
            this.Btn4.Name = "Btn4";
            this.Btn4.Size = new System.Drawing.Size(69, 50);
            this.Btn4.TabIndex = 3;
            this.Btn4.Text = "4";
            this.Btn4.UseVisualStyleBackColor = false;
            this.Btn4.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn5
            // 
            this.Btn5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn5.FlatAppearance.BorderSize = 0;
            this.Btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn5.Location = new System.Drawing.Point(68, 258);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(69, 50);
            this.Btn5.TabIndex = 3;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = false;
            this.Btn5.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn6
            // 
            this.Btn6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn6.FlatAppearance.BorderSize = 0;
            this.Btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn6.Location = new System.Drawing.Point(136, 258);
            this.Btn6.Name = "Btn6";
            this.Btn6.Size = new System.Drawing.Size(69, 50);
            this.Btn6.TabIndex = 3;
            this.Btn6.Text = "6";
            this.Btn6.UseVisualStyleBackColor = false;
            this.Btn6.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnMinus
            // 
            this.BtnMinus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnMinus.FlatAppearance.BorderSize = 0;
            this.BtnMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinus.Location = new System.Drawing.Point(199, 258);
            this.BtnMinus.Name = "BtnMinus";
            this.BtnMinus.Size = new System.Drawing.Size(69, 50);
            this.BtnMinus.TabIndex = 3;
            this.BtnMinus.Text = "-";
            this.BtnMinus.UseVisualStyleBackColor = false;
            this.BtnMinus.Click += new System.EventHandler(this.BtnOP_Click);
            // 
            // Btn1
            // 
            this.Btn1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn1.FlatAppearance.BorderSize = 0;
            this.Btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1.Location = new System.Drawing.Point(0, 297);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(69, 50);
            this.Btn1.TabIndex = 3;
            this.Btn1.Text = "1";
            this.Btn1.UseVisualStyleBackColor = false;
            this.Btn1.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn2
            // 
            this.Btn2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn2.FlatAppearance.BorderSize = 0;
            this.Btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn2.Location = new System.Drawing.Point(68, 297);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(69, 50);
            this.Btn2.TabIndex = 3;
            this.Btn2.Text = "2";
            this.Btn2.UseVisualStyleBackColor = false;
            this.Btn2.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // Btn3
            // 
            this.Btn3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn3.FlatAppearance.BorderSize = 0;
            this.Btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn3.Location = new System.Drawing.Point(136, 297);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(69, 50);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = false;
            this.Btn3.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnPlus
            // 
            this.BtnPlus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnPlus.FlatAppearance.BorderSize = 0;
            this.BtnPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPlus.Location = new System.Drawing.Point(199, 297);
            this.BtnPlus.Name = "BtnPlus";
            this.BtnPlus.Size = new System.Drawing.Size(69, 50);
            this.BtnPlus.TabIndex = 3;
            this.BtnPlus.Text = "+";
            this.BtnPlus.UseVisualStyleBackColor = false;
            this.BtnPlus.Click += new System.EventHandler(this.BtnOP_Click);
            // 
            // BtnSign
            // 
            this.BtnSign.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSign.FlatAppearance.BorderSize = 0;
            this.BtnSign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSign.Location = new System.Drawing.Point(0, 335);
            this.BtnSign.Name = "BtnSign";
            this.BtnSign.Size = new System.Drawing.Size(69, 50);
            this.BtnSign.TabIndex = 3;
            this.BtnSign.Text = "±";
            this.BtnSign.UseVisualStyleBackColor = false;
            // 
            // Btn0
            // 
            this.Btn0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Btn0.FlatAppearance.BorderSize = 0;
            this.Btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn0.Location = new System.Drawing.Point(68, 335);
            this.Btn0.Name = "Btn0";
            this.Btn0.Size = new System.Drawing.Size(69, 50);
            this.Btn0.TabIndex = 3;
            this.Btn0.Text = "0";
            this.Btn0.UseVisualStyleBackColor = false;
            this.Btn0.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // BtnDot
            // 
            this.BtnDot.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnDot.FlatAppearance.BorderSize = 0;
            this.BtnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDot.Location = new System.Drawing.Point(136, 335);
            this.BtnDot.Name = "BtnDot";
            this.BtnDot.Size = new System.Drawing.Size(69, 50);
            this.BtnDot.TabIndex = 3;
            this.BtnDot.Text = ".";
            this.BtnDot.UseVisualStyleBackColor = false;
            // 
            // BtnEqual
            // 
            this.BtnEqual.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEqual.FlatAppearance.BorderSize = 0;
            this.BtnEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEqual.Location = new System.Drawing.Point(199, 335);
            this.BtnEqual.Name = "BtnEqual";
            this.BtnEqual.Size = new System.Drawing.Size(69, 50);
            this.BtnEqual.TabIndex = 3;
            this.BtnEqual.Text = "=";
            this.BtnEqual.UseVisualStyleBackColor = false;
            this.BtnEqual.Click += new System.EventHandler(this.BtnEqual_Click);
            // 
            // TxtExp
            // 
            this.TxtExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtExp.Font = new System.Drawing.Font("궁서체", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.TxtExp.Location = new System.Drawing.Point(0, 12);
            this.TxtExp.Name = "TxtExp";
            this.TxtExp.Size = new System.Drawing.Size(262, 18);
            this.TxtExp.TabIndex = 0;
            this.TxtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(264, 381);
            this.Controls.Add(this.BtnEqual);
            this.Controls.Add(this.BtnPlus);
            this.Controls.Add(this.BtnMinus);
            this.Controls.Add(this.BtnMultiple);
            this.Controls.Add(this.BtnDivide);
            this.Controls.Add(this.BtnDot);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn6);
            this.Controls.Add(this.Btn9);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.Btn0);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.BtnC);
            this.Controls.Add(this.BtnSign);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.Btn4);
            this.Controls.Add(this.Btn7);
            this.Controls.Add(this.BtnCE);
            this.Controls.Add(this.BtnMS);
            this.Controls.Add(this.BtnMMinus);
            this.Controls.Add(this.BtnMPlus);
            this.Controls.Add(this.BtnMR);
            this.Controls.Add(this.BtnRecip);
            this.Controls.Add(this.BtnSqr);
            this.Controls.Add(this.BtnSqrt);
            this.Controls.Add(this.BtnPercent);
            this.Controls.Add(this.BtnMC);
            this.Controls.Add(this.TxtExp);
            this.Controls.Add(this.TxtResult);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "윈도우 계산기";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.Button BtnMC;
        private System.Windows.Forms.Button BtnCE;
        private System.Windows.Forms.Button BtnMR;
        private System.Windows.Forms.Button BtnMPlus;
        private System.Windows.Forms.Button BtnMMinus;
        private System.Windows.Forms.Button BtnMS;
        private System.Windows.Forms.Button BtnPercent;
        private System.Windows.Forms.Button BtnSqrt;
        private System.Windows.Forms.Button BtnSqr;
        private System.Windows.Forms.Button BtnRecip;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnDivide;
        private System.Windows.Forms.Button Btn7;
        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn9;
        private System.Windows.Forms.Button BtnMultiple;
        private System.Windows.Forms.Button Btn4;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn6;
        private System.Windows.Forms.Button BtnMinus;
        private System.Windows.Forms.Button Btn1;
        private System.Windows.Forms.Button Btn2;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Button BtnPlus;
        private System.Windows.Forms.Button BtnSign;
        private System.Windows.Forms.Button Btn0;
        private System.Windows.Forms.Button BtnDot;
        private System.Windows.Forms.Button BtnEqual;
        private System.Windows.Forms.TextBox TxtExp;
    }
}

