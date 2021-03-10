
namespace ListboxWinApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LsbGDP = new System.Windows.Forms.ListBox();
            this.LsbCity = new System.Windows.Forms.ListBox();
            this.LsbCountry = new System.Windows.Forms.ListBox();
            this.TxtGDPIndex = new System.Windows.Forms.TextBox();
            this.TxtGDPItem = new System.Windows.Forms.TextBox();
            this.TxtCityIndex = new System.Windows.Forms.TextBox();
            this.TxtCityItem = new System.Windows.Forms.TextBox();
            this.TxtCountryIndex = new System.Windows.Forms.TextBox();
            this.TxtCountryItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "GDP순위";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "살기좋은도시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(522, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "행복한나라";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "SelectedIndex :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "SelectedItem :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // LsbGDP
            // 
            this.LsbGDP.FormattingEnabled = true;
            this.LsbGDP.ItemHeight = 12;
            this.LsbGDP.Items.AddRange(new object[] {
            "미국",
            "러시아",
            "영국",
            "중국",
            "한국",
            "일본",
            "독일",
            "프랑스"});
            this.LsbGDP.Location = new System.Drawing.Point(218, 129);
            this.LsbGDP.Name = "LsbGDP";
            this.LsbGDP.Size = new System.Drawing.Size(120, 172);
            this.LsbGDP.TabIndex = 5;
            this.LsbGDP.SelectedIndexChanged += new System.EventHandler(this.LsbGDP_SelectedIndexChanged);
            // 
            // LsbCity
            // 
            this.LsbCity.FormattingEnabled = true;
            this.LsbCity.ItemHeight = 12;
            this.LsbCity.Location = new System.Drawing.Point(371, 129);
            this.LsbCity.Name = "LsbCity";
            this.LsbCity.Size = new System.Drawing.Size(120, 172);
            this.LsbCity.TabIndex = 6;
            this.LsbCity.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // LsbCountry
            // 
            this.LsbCountry.FormattingEnabled = true;
            this.LsbCountry.ItemHeight = 12;
            this.LsbCountry.Location = new System.Drawing.Point(524, 129);
            this.LsbCountry.Name = "LsbCountry";
            this.LsbCountry.Size = new System.Drawing.Size(120, 172);
            this.LsbCountry.TabIndex = 7;
            this.LsbCountry.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // TxtGDPIndex
            // 
            this.TxtGDPIndex.Location = new System.Drawing.Point(218, 326);
            this.TxtGDPIndex.Name = "TxtGDPIndex";
            this.TxtGDPIndex.Size = new System.Drawing.Size(120, 21);
            this.TxtGDPIndex.TabIndex = 8;
            // 
            // TxtGDPItem
            // 
            this.TxtGDPItem.Location = new System.Drawing.Point(218, 369);
            this.TxtGDPItem.Name = "TxtGDPItem";
            this.TxtGDPItem.Size = new System.Drawing.Size(120, 21);
            this.TxtGDPItem.TabIndex = 9;
            // 
            // TxtCityIndex
            // 
            this.TxtCityIndex.Location = new System.Drawing.Point(371, 326);
            this.TxtCityIndex.Name = "TxtCityIndex";
            this.TxtCityIndex.Size = new System.Drawing.Size(120, 21);
            this.TxtCityIndex.TabIndex = 10;
            // 
            // TxtCityItem
            // 
            this.TxtCityItem.Location = new System.Drawing.Point(371, 369);
            this.TxtCityItem.Name = "TxtCityItem";
            this.TxtCityItem.Size = new System.Drawing.Size(120, 21);
            this.TxtCityItem.TabIndex = 11;
            // 
            // TxtCountryIndex
            // 
            this.TxtCountryIndex.Location = new System.Drawing.Point(524, 326);
            this.TxtCountryIndex.Name = "TxtCountryIndex";
            this.TxtCountryIndex.Size = new System.Drawing.Size(120, 21);
            this.TxtCountryIndex.TabIndex = 12;
            // 
            // TxtCountryItem
            // 
            this.TxtCountryItem.Location = new System.Drawing.Point(524, 369);
            this.TxtCountryItem.Name = "TxtCountryItem";
            this.TxtCountryItem.Size = new System.Drawing.Size(120, 21);
            this.TxtCountryItem.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtCountryItem);
            this.Controls.Add(this.TxtCountryIndex);
            this.Controls.Add(this.TxtCityItem);
            this.Controls.Add(this.TxtCityIndex);
            this.Controls.Add(this.TxtGDPItem);
            this.Controls.Add(this.TxtGDPIndex);
            this.Controls.Add(this.LsbCountry);
            this.Controls.Add(this.LsbCity);
            this.Controls.Add(this.LsbGDP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LsbGDP;
        private System.Windows.Forms.ListBox LsbCity;
        private System.Windows.Forms.ListBox LsbCountry;
        private System.Windows.Forms.TextBox TxtGDPIndex;
        private System.Windows.Forms.TextBox TxtGDPItem;
        private System.Windows.Forms.TextBox TxtCityIndex;
        private System.Windows.Forms.TextBox TxtCityItem;
        private System.Windows.Forms.TextBox TxtCountryIndex;
        private System.Windows.Forms.TextBox TxtCountryItem;
    }
}

