
namespace ListViewApp
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
            this.components = new System.ComponentModel.Container();
            this.RdbDetails = new System.Windows.Forms.RadioButton();
            this.RdbList = new System.Windows.Forms.RadioButton();
            this.RdbSmallIcon = new System.Windows.Forms.RadioButton();
            this.RdbLargeIcon = new System.Windows.Forms.RadioButton();
            this.LsbProduct = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ImgSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.ImgLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // RdbDetails
            // 
            this.RdbDetails.AutoSize = true;
            this.RdbDetails.Location = new System.Drawing.Point(26, 29);
            this.RdbDetails.Name = "RdbDetails";
            this.RdbDetails.Size = new System.Drawing.Size(59, 16);
            this.RdbDetails.TabIndex = 0;
            this.RdbDetails.TabStop = true;
            this.RdbDetails.Text = "자세히";
            this.RdbDetails.UseVisualStyleBackColor = true;
            this.RdbDetails.CheckedChanged += new System.EventHandler(this.RdbDetails_CheckedChanged);
            // 
            // RdbList
            // 
            this.RdbList.AutoSize = true;
            this.RdbList.Location = new System.Drawing.Point(226, 29);
            this.RdbList.Name = "RdbList";
            this.RdbList.Size = new System.Drawing.Size(59, 16);
            this.RdbList.TabIndex = 1;
            this.RdbList.TabStop = true;
            this.RdbList.Text = "리스트";
            this.RdbList.UseVisualStyleBackColor = true;
            this.RdbList.CheckedChanged += new System.EventHandler(this.RdbList_CheckedChanged);
            // 
            // RdbSmallIcon
            // 
            this.RdbSmallIcon.AutoSize = true;
            this.RdbSmallIcon.Location = new System.Drawing.Point(458, 29);
            this.RdbSmallIcon.Name = "RdbSmallIcon";
            this.RdbSmallIcon.Size = new System.Drawing.Size(87, 16);
            this.RdbSmallIcon.TabIndex = 2;
            this.RdbSmallIcon.TabStop = true;
            this.RdbSmallIcon.Text = "작은 아이콘";
            this.RdbSmallIcon.UseVisualStyleBackColor = true;
            this.RdbSmallIcon.CheckedChanged += new System.EventHandler(this.RdbSmallIcon_CheckedChanged);
            // 
            // RdbLargeIcon
            // 
            this.RdbLargeIcon.AutoSize = true;
            this.RdbLargeIcon.Location = new System.Drawing.Point(660, 29);
            this.RdbLargeIcon.Name = "RdbLargeIcon";
            this.RdbLargeIcon.Size = new System.Drawing.Size(75, 16);
            this.RdbLargeIcon.TabIndex = 3;
            this.RdbLargeIcon.TabStop = true;
            this.RdbLargeIcon.Text = "큰 아이콘";
            this.RdbLargeIcon.UseVisualStyleBackColor = true;
            this.RdbLargeIcon.CheckedChanged += new System.EventHandler(this.RdbLargeIcon_CheckedChanged);
            // 
            // LsbProduct
            // 
            this.LsbProduct.FormattingEnabled = true;
            this.LsbProduct.ItemHeight = 12;
            this.LsbProduct.Items.AddRange(new object[] {
            "제품명 단가 수량 가격"});
            this.LsbProduct.Location = new System.Drawing.Point(19, 78);
            this.LsbProduct.MultiColumn = true;
            this.LsbProduct.Name = "LsbProduct";
            this.LsbProduct.Size = new System.Drawing.Size(747, 232);
            this.LsbProduct.TabIndex = 4;
            this.LsbProduct.SelectedIndexChanged += new System.EventHandler(this.LsbProduct_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 366);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(454, 21);
            this.textBox1.TabIndex = 6;
            // 
            // ImgSmallIcon
            // 
            this.ImgSmallIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgSmallIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ImgLargeIcon
            // 
            this.ImgLargeIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgLargeIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LsbProduct);
            this.Controls.Add(this.RdbLargeIcon);
            this.Controls.Add(this.RdbSmallIcon);
            this.Controls.Add(this.RdbList);
            this.Controls.Add(this.RdbDetails);
            this.Name = "FrmMain";
            this.Text = "상품리스트";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdbDetails;
        private System.Windows.Forms.RadioButton RdbList;
        private System.Windows.Forms.RadioButton RdbSmallIcon;
        private System.Windows.Forms.RadioButton RdbLargeIcon;
        private System.Windows.Forms.ListBox LsbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList ImgSmallIcon;
        private System.Windows.Forms.ImageList ImgLargeIcon;
    }
}

