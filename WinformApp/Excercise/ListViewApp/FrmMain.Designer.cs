
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.RdbDetails = new System.Windows.Forms.RadioButton();
            this.RdbList = new System.Windows.Forms.RadioButton();
            this.RdbSmallIcon = new System.Windows.Forms.RadioButton();
            this.RdbLargeIcon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSelected = new System.Windows.Forms.TextBox();
            this.ImgSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.ImgLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.LsvProducts = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.RdbList.Location = new System.Drawing.Point(121, 29);
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
            this.RdbSmallIcon.Location = new System.Drawing.Point(263, 29);
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
            this.RdbLargeIcon.Location = new System.Drawing.Point(440, 29);
            this.RdbLargeIcon.Name = "RdbLargeIcon";
            this.RdbLargeIcon.Size = new System.Drawing.Size(75, 16);
            this.RdbLargeIcon.TabIndex = 3;
            this.RdbLargeIcon.TabStop = true;
            this.RdbLargeIcon.Text = "큰 아이콘";
            this.RdbLargeIcon.UseVisualStyleBackColor = true;
            this.RdbLargeIcon.CheckedChanged += new System.EventHandler(this.RdbLargeIcon_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected :";
            // 
            // TxtSelected
            // 
            this.TxtSelected.Location = new System.Drawing.Point(159, 360);
            this.TxtSelected.Name = "TxtSelected";
            this.TxtSelected.Size = new System.Drawing.Size(386, 21);
            this.TxtSelected.TabIndex = 6;
            // 
            // ImgSmallIcon
            // 
            this.ImgSmallIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgSmallIcon.ImageStream")));
            this.ImgSmallIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgSmallIcon.Images.SetKeyName(0, "controller.png");
            this.ImgSmallIcon.Images.SetKeyName(1, "ds.png");
            this.ImgSmallIcon.Images.SetKeyName(2, "ps4.png");
            this.ImgSmallIcon.Images.SetKeyName(3, "remote.png");
            this.ImgSmallIcon.Images.SetKeyName(4, "xbox.png");
            // 
            // ImgLargeIcon
            // 
            this.ImgLargeIcon.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgLargeIcon.ImageStream")));
            this.ImgLargeIcon.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgLargeIcon.Images.SetKeyName(0, "controller.png");
            this.ImgLargeIcon.Images.SetKeyName(1, "ds.png");
            this.ImgLargeIcon.Images.SetKeyName(2, "ps4.png");
            this.ImgLargeIcon.Images.SetKeyName(3, "remote.png");
            this.ImgLargeIcon.Images.SetKeyName(4, "xbox.png");
            // 
            // LsvProducts
            // 
            this.LsvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.LsvProducts.FullRowSelect = true;
            this.LsvProducts.GridLines = true;
            this.LsvProducts.HideSelection = false;
            this.LsvProducts.LargeImageList = this.ImgLargeIcon;
            this.LsvProducts.Location = new System.Drawing.Point(26, 51);
            this.LsvProducts.Name = "LsvProducts";
            this.LsvProducts.Size = new System.Drawing.Size(519, 296);
            this.LsvProducts.SmallImageList = this.ImgSmallIcon;
            this.LsvProducts.TabIndex = 7;
            this.LsvProducts.UseCompatibleStateImageBehavior = false;
            this.LsvProducts.View = System.Windows.Forms.View.Details;
            this.LsvProducts.SelectedIndexChanged += new System.EventHandler(this.LsvProducts_SelectedIndexChanged_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "제품명";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "단가";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "수량";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "금액";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 120;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 398);
            this.Controls.Add(this.LsvProducts);
            this.Controls.Add(this.TxtSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RdbLargeIcon);
            this.Controls.Add(this.RdbSmallIcon);
            this.Controls.Add(this.RdbList);
            this.Controls.Add(this.RdbDetails);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSelected;
        private System.Windows.Forms.ImageList ImgSmallIcon;
        private System.Windows.Forms.ImageList ImgLargeIcon;
        private System.Windows.Forms.ListView LsvProducts;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

