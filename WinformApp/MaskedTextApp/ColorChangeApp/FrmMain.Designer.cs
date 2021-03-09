
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtR = new System.Windows.Forms.TextBox();
            this.TxtG = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.BtnColor = new System.Windows.Forms.Button();
            this.TrbR = new System.Windows.Forms.TrackBar();
            this.TrbG = new System.Windows.Forms.TrackBar();
            this.TrbB = new System.Windows.Forms.TrackBar();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.TrbR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 113);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "G";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "R";
            // 
            // TxtR
            // 
            this.TxtR.Location = new System.Drawing.Point(217, 132);
            this.TxtR.Name = "TxtR";
            this.TxtR.ReadOnly = true;
            this.TxtR.Size = new System.Drawing.Size(100, 21);
            this.TxtR.TabIndex = 13;
            this.TxtR.Text = "0";
            this.TxtR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtG
            // 
            this.TxtG.Location = new System.Drawing.Point(217, 168);
            this.TxtG.Name = "TxtG";
            this.TxtG.ReadOnly = true;
            this.TxtG.Size = new System.Drawing.Size(100, 21);
            this.TxtG.TabIndex = 14;
            this.TxtG.Text = "0";
            this.TxtG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(217, 210);
            this.TxtB.Name = "TxtB";
            this.TxtB.ReadOnly = true;
            this.TxtB.Size = new System.Drawing.Size(100, 21);
            this.TxtB.TabIndex = 15;
            this.TxtB.Text = "0";
            this.TxtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(42, 266);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(75, 23);
            this.BtnColor.TabIndex = 16;
            this.BtnColor.Text = "...";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // TrbR
            // 
            this.TrbR.Location = new System.Drawing.Point(54, 132);
            this.TrbR.Maximum = 255;
            this.TrbR.Name = "TrbR";
            this.TrbR.Size = new System.Drawing.Size(157, 45);
            this.TrbR.TabIndex = 17;
            this.TrbR.TickFrequency = 5;
            this.TrbR.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // TrbG
            // 
            this.TrbG.Location = new System.Drawing.Point(54, 168);
            this.TrbG.Maximum = 255;
            this.TrbG.Name = "TrbG";
            this.TrbG.Size = new System.Drawing.Size(157, 45);
            this.TrbG.TabIndex = 18;
            this.TrbG.TickFrequency = 5;
            this.TrbG.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // TrbB
            // 
            this.TrbB.Location = new System.Drawing.Point(54, 210);
            this.TrbB.Maximum = 255;
            this.TrbB.Name = "TrbB";
            this.TrbB.Size = new System.Drawing.Size(157, 45);
            this.TrbB.TabIndex = 19;
            this.TrbB.TickFrequency = 5;
            this.TrbB.Scroll += new System.EventHandler(this.Trackbar_Scroll);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(136, 266);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(75, 23);
            this.BtnOpen.TabIndex = 20;
            this.BtnOpen.Text = "...";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(230, 266);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 21;
            this.BtnSave.Text = "...";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(343, 305);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.TrbB);
            this.Controls.Add(this.TrbG);
            this.Controls.Add(this.TrbR);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.TxtB);
            this.Controls.Add(this.TxtG);
            this.Controls.Add(this.TxtR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "RGB Color Scroller";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrbR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TrbB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtR;
        private System.Windows.Forms.TextBox TxtG;
        private System.Windows.Forms.TextBox TxtB;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.TrackBar TrbR;
        private System.Windows.Forms.TrackBar TrbG;
        private System.Windows.Forms.TrackBar TrbB;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

