
namespace GradeCalcApp
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
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.Txt3 = new System.Windows.Forms.TextBox();
            this.Txt4 = new System.Windows.Forms.TextBox();
            this.Txt5 = new System.Windows.Forms.TextBox();
            this.Txt6 = new System.Windows.Forms.TextBox();
            this.Txt7 = new System.Windows.Forms.TextBox();
            this.Cmb1 = new System.Windows.Forms.ComboBox();
            this.Cmb2 = new System.Windows.Forms.ComboBox();
            this.Cmb3 = new System.Windows.Forms.ComboBox();
            this.Cmb4 = new System.Windows.Forms.ComboBox();
            this.Cmb5 = new System.Windows.Forms.ComboBox();
            this.Cmb6 = new System.Windows.Forms.ComboBox();
            this.Cmb7 = new System.Windows.Forms.ComboBox();
            this.Grd7 = new System.Windows.Forms.ComboBox();
            this.Grd6 = new System.Windows.Forms.ComboBox();
            this.Grd5 = new System.Windows.Forms.ComboBox();
            this.Grd4 = new System.Windows.Forms.ComboBox();
            this.Grd3 = new System.Windows.Forms.ComboBox();
            this.Grd2 = new System.Windows.Forms.ComboBox();
            this.Grd1 = new System.Windows.Forms.ComboBox();
            this.BtnAvg = new System.Windows.Forms.Button();
            this.TxtAvg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "과목명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "학점";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "성적";
            // 
            // Txt1
            // 
            this.Txt1.Location = new System.Drawing.Point(89, 74);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(100, 21);
            this.Txt1.TabIndex = 3;
            // 
            // Txt2
            // 
            this.Txt2.Location = new System.Drawing.Point(89, 101);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(100, 21);
            this.Txt2.TabIndex = 4;
            // 
            // Txt3
            // 
            this.Txt3.Location = new System.Drawing.Point(89, 128);
            this.Txt3.Name = "Txt3";
            this.Txt3.Size = new System.Drawing.Size(100, 21);
            this.Txt3.TabIndex = 5;
            // 
            // Txt4
            // 
            this.Txt4.Location = new System.Drawing.Point(89, 155);
            this.Txt4.Name = "Txt4";
            this.Txt4.Size = new System.Drawing.Size(100, 21);
            this.Txt4.TabIndex = 6;
            // 
            // Txt5
            // 
            this.Txt5.Location = new System.Drawing.Point(89, 182);
            this.Txt5.Name = "Txt5";
            this.Txt5.Size = new System.Drawing.Size(100, 21);
            this.Txt5.TabIndex = 7;
            // 
            // Txt6
            // 
            this.Txt6.Location = new System.Drawing.Point(89, 209);
            this.Txt6.Name = "Txt6";
            this.Txt6.Size = new System.Drawing.Size(100, 21);
            this.Txt6.TabIndex = 8;
            this.Txt6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Txt7
            // 
            this.Txt7.Location = new System.Drawing.Point(89, 236);
            this.Txt7.Name = "Txt7";
            this.Txt7.Size = new System.Drawing.Size(100, 21);
            this.Txt7.TabIndex = 9;
            // 
            // Cmb1
            // 
            this.Cmb1.FormattingEnabled = true;
            this.Cmb1.Location = new System.Drawing.Point(216, 74);
            this.Cmb1.Name = "Cmb1";
            this.Cmb1.Size = new System.Drawing.Size(121, 20);
            this.Cmb1.TabIndex = 10;
            // 
            // Cmb2
            // 
            this.Cmb2.FormattingEnabled = true;
            this.Cmb2.Location = new System.Drawing.Point(216, 101);
            this.Cmb2.Name = "Cmb2";
            this.Cmb2.Size = new System.Drawing.Size(121, 20);
            this.Cmb2.TabIndex = 11;
            // 
            // Cmb3
            // 
            this.Cmb3.FormattingEnabled = true;
            this.Cmb3.Location = new System.Drawing.Point(216, 128);
            this.Cmb3.Name = "Cmb3";
            this.Cmb3.Size = new System.Drawing.Size(121, 20);
            this.Cmb3.TabIndex = 12;
            // 
            // Cmb4
            // 
            this.Cmb4.FormattingEnabled = true;
            this.Cmb4.Location = new System.Drawing.Point(216, 155);
            this.Cmb4.Name = "Cmb4";
            this.Cmb4.Size = new System.Drawing.Size(121, 20);
            this.Cmb4.TabIndex = 13;
            // 
            // Cmb5
            // 
            this.Cmb5.FormattingEnabled = true;
            this.Cmb5.Location = new System.Drawing.Point(216, 182);
            this.Cmb5.Name = "Cmb5";
            this.Cmb5.Size = new System.Drawing.Size(121, 20);
            this.Cmb5.TabIndex = 14;
            // 
            // Cmb6
            // 
            this.Cmb6.FormattingEnabled = true;
            this.Cmb6.Location = new System.Drawing.Point(216, 209);
            this.Cmb6.Name = "Cmb6";
            this.Cmb6.Size = new System.Drawing.Size(121, 20);
            this.Cmb6.TabIndex = 15;
            this.Cmb6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // Cmb7
            // 
            this.Cmb7.FormattingEnabled = true;
            this.Cmb7.Location = new System.Drawing.Point(216, 236);
            this.Cmb7.Name = "Cmb7";
            this.Cmb7.Size = new System.Drawing.Size(121, 20);
            this.Cmb7.TabIndex = 16;
            // 
            // Grd7
            // 
            this.Grd7.FormattingEnabled = true;
            this.Grd7.Location = new System.Drawing.Point(361, 236);
            this.Grd7.Name = "Grd7";
            this.Grd7.Size = new System.Drawing.Size(121, 20);
            this.Grd7.TabIndex = 23;
            // 
            // Grd6
            // 
            this.Grd6.FormattingEnabled = true;
            this.Grd6.Location = new System.Drawing.Point(361, 209);
            this.Grd6.Name = "Grd6";
            this.Grd6.Size = new System.Drawing.Size(121, 20);
            this.Grd6.TabIndex = 22;
            // 
            // Grd5
            // 
            this.Grd5.FormattingEnabled = true;
            this.Grd5.Location = new System.Drawing.Point(361, 182);
            this.Grd5.Name = "Grd5";
            this.Grd5.Size = new System.Drawing.Size(121, 20);
            this.Grd5.TabIndex = 21;
            // 
            // Grd4
            // 
            this.Grd4.FormattingEnabled = true;
            this.Grd4.Location = new System.Drawing.Point(361, 155);
            this.Grd4.Name = "Grd4";
            this.Grd4.Size = new System.Drawing.Size(121, 20);
            this.Grd4.TabIndex = 20;
            // 
            // Grd3
            // 
            this.Grd3.FormattingEnabled = true;
            this.Grd3.Location = new System.Drawing.Point(361, 128);
            this.Grd3.Name = "Grd3";
            this.Grd3.Size = new System.Drawing.Size(121, 20);
            this.Grd3.TabIndex = 19;
            // 
            // Grd2
            // 
            this.Grd2.FormattingEnabled = true;
            this.Grd2.Location = new System.Drawing.Point(361, 101);
            this.Grd2.Name = "Grd2";
            this.Grd2.Size = new System.Drawing.Size(121, 20);
            this.Grd2.TabIndex = 18;
            // 
            // Grd1
            // 
            this.Grd1.FormattingEnabled = true;
            this.Grd1.Location = new System.Drawing.Point(361, 74);
            this.Grd1.Name = "Grd1";
            this.Grd1.Size = new System.Drawing.Size(121, 20);
            this.Grd1.TabIndex = 17;
            // 
            // BtnAvg
            // 
            this.BtnAvg.Location = new System.Drawing.Point(216, 262);
            this.BtnAvg.Name = "BtnAvg";
            this.BtnAvg.Size = new System.Drawing.Size(121, 39);
            this.BtnAvg.TabIndex = 24;
            this.BtnAvg.Text = "평균성적";
            this.BtnAvg.UseVisualStyleBackColor = true;
            this.BtnAvg.Click += new System.EventHandler(this.BtnAvg_Click);
            // 
            // TxtAvg
            // 
            this.TxtAvg.Location = new System.Drawing.Point(361, 275);
            this.TxtAvg.Name = "TxtAvg";
            this.TxtAvg.Size = new System.Drawing.Size(121, 21);
            this.TxtAvg.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 313);
            this.Controls.Add(this.TxtAvg);
            this.Controls.Add(this.BtnAvg);
            this.Controls.Add(this.Grd7);
            this.Controls.Add(this.Grd6);
            this.Controls.Add(this.Grd5);
            this.Controls.Add(this.Grd4);
            this.Controls.Add(this.Grd3);
            this.Controls.Add(this.Grd2);
            this.Controls.Add(this.Grd1);
            this.Controls.Add(this.Cmb7);
            this.Controls.Add(this.Cmb6);
            this.Controls.Add(this.Cmb5);
            this.Controls.Add(this.Cmb4);
            this.Controls.Add(this.Cmb3);
            this.Controls.Add(this.Cmb2);
            this.Controls.Add(this.Cmb1);
            this.Controls.Add(this.Txt7);
            this.Controls.Add(this.Txt6);
            this.Controls.Add(this.Txt5);
            this.Controls.Add(this.Txt4);
            this.Controls.Add(this.Txt3);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Txt1);
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
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.TextBox Txt3;
        private System.Windows.Forms.TextBox Txt4;
        private System.Windows.Forms.TextBox Txt5;
        private System.Windows.Forms.TextBox Txt6;
        private System.Windows.Forms.TextBox Txt7;
        private System.Windows.Forms.ComboBox Cmb1;
        private System.Windows.Forms.ComboBox Cmb2;
        private System.Windows.Forms.ComboBox Cmb3;
        private System.Windows.Forms.ComboBox Cmb4;
        private System.Windows.Forms.ComboBox Cmb5;
        private System.Windows.Forms.ComboBox Cmb6;
        private System.Windows.Forms.ComboBox Cmb7;
        private System.Windows.Forms.ComboBox Grd7;
        private System.Windows.Forms.ComboBox Grd6;
        private System.Windows.Forms.ComboBox Grd5;
        private System.Windows.Forms.ComboBox Grd4;
        private System.Windows.Forms.ComboBox Grd3;
        private System.Windows.Forms.ComboBox Grd2;
        private System.Windows.Forms.ComboBox Grd1;
        private System.Windows.Forms.Button BtnAvg;
        private System.Windows.Forms.TextBox TxtAvg;
    }
}

