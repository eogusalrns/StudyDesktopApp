
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
            this.Lsv = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RdbDetail = new System.Windows.Forms.RadioButton();
            this.RdbList = new System.Windows.Forms.RadioButton();
            this.RdbSmall = new System.Windows.Forms.RadioButton();
            this.RdbBig = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSelected = new System.Windows.Forms.TextBox();
            this.ImgSmallIcon = new System.Windows.Forms.ImageList(this.components);
            this.ImgLargeIcon = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // Lsv
            // 
            this.Lsv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.unitPrice,
            this.quantity,
            this.price});
            this.Lsv.FullRowSelect = true;
            this.Lsv.GridLines = true;
            this.Lsv.HideSelection = false;
            this.Lsv.LargeImageList = this.ImgLargeIcon;
            this.Lsv.Location = new System.Drawing.Point(12, 35);
            this.Lsv.Name = "Lsv";
            this.Lsv.Size = new System.Drawing.Size(426, 200);
            this.Lsv.SmallImageList = this.ImgSmallIcon;
            this.Lsv.TabIndex = 0;
            this.Lsv.UseCompatibleStateImageBehavior = false;
            this.Lsv.View = System.Windows.Forms.View.Details;
            this.Lsv.SelectedIndexChanged += new System.EventHandler(this.Lsv_SelectedIndexChanged);
            // 
            // productName
            // 
            this.productName.Text = "제품명";
            this.productName.Width = 150;
            // 
            // unitPrice
            // 
            this.unitPrice.Text = "단가";
            this.unitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitPrice.Width = 100;
            // 
            // quantity
            // 
            this.quantity.Text = "수량";
            this.quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantity.Width = 70;
            // 
            // price
            // 
            this.price.Text = "금액";
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.price.Width = 100;
            // 
            // RdbDetail
            // 
            this.RdbDetail.AutoSize = true;
            this.RdbDetail.Checked = true;
            this.RdbDetail.Location = new System.Drawing.Point(12, 13);
            this.RdbDetail.Name = "RdbDetail";
            this.RdbDetail.Size = new System.Drawing.Size(59, 16);
            this.RdbDetail.TabIndex = 1;
            this.RdbDetail.TabStop = true;
            this.RdbDetail.Text = "자세히";
            this.RdbDetail.UseVisualStyleBackColor = true;
            this.RdbDetail.CheckedChanged += new System.EventHandler(this.RdbDetail_CheckedChanged);
            // 
            // RdbList
            // 
            this.RdbList.AutoSize = true;
            this.RdbList.Location = new System.Drawing.Point(118, 13);
            this.RdbList.Name = "RdbList";
            this.RdbList.Size = new System.Drawing.Size(59, 16);
            this.RdbList.TabIndex = 2;
            this.RdbList.Text = "리스트";
            this.RdbList.UseVisualStyleBackColor = true;
            this.RdbList.CheckedChanged += new System.EventHandler(this.RdbList_CheckedChanged);
            // 
            // RdbSmall
            // 
            this.RdbSmall.AutoSize = true;
            this.RdbSmall.Location = new System.Drawing.Point(224, 13);
            this.RdbSmall.Name = "RdbSmall";
            this.RdbSmall.Size = new System.Drawing.Size(87, 16);
            this.RdbSmall.TabIndex = 3;
            this.RdbSmall.Text = "작은 아이콘";
            this.RdbSmall.UseVisualStyleBackColor = true;
            this.RdbSmall.CheckedChanged += new System.EventHandler(this.RdbSmall_CheckedChanged);
            // 
            // RdbBig
            // 
            this.RdbBig.AutoSize = true;
            this.RdbBig.Location = new System.Drawing.Point(358, 12);
            this.RdbBig.Name = "RdbBig";
            this.RdbBig.Size = new System.Drawing.Size(75, 16);
            this.RdbBig.TabIndex = 4;
            this.RdbBig.Text = "큰 아이콘";
            this.RdbBig.UseVisualStyleBackColor = true;
            this.RdbBig.CheckedChanged += new System.EventHandler(this.RdbBig_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected : ";
            // 
            // TxtSelected
            // 
            this.TxtSelected.Location = new System.Drawing.Point(335, 241);
            this.TxtSelected.Name = "TxtSelected";
            this.TxtSelected.Size = new System.Drawing.Size(100, 21);
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
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 273);
            this.Controls.Add(this.TxtSelected);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RdbBig);
            this.Controls.Add(this.RdbSmall);
            this.Controls.Add(this.RdbList);
            this.Controls.Add(this.RdbDetail);
            this.Controls.Add(this.Lsv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "상품리스트";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView Lsv;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader unitPrice;
        private System.Windows.Forms.ColumnHeader quantity;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.RadioButton RdbDetail;
        private System.Windows.Forms.RadioButton RdbList;
        private System.Windows.Forms.RadioButton RdbSmall;
        private System.Windows.Forms.RadioButton RdbBig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSelected;
        private System.Windows.Forms.ImageList ImgSmallIcon;
        private System.Windows.Forms.ImageList ImgLargeIcon;
    }
}

