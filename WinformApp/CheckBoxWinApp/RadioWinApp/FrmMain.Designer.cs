
namespace RadioWinApp
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
            this.BtnResult = new System.Windows.Forms.Button();
            this.RdbKor = new System.Windows.Forms.RadioButton();
            this.RdbChi = new System.Windows.Forms.RadioButton();
            this.RdbJap = new System.Windows.Forms.RadioButton();
            this.Rdbetc = new System.Windows.Forms.RadioButton();
            this.RdbM = new System.Windows.Forms.RadioButton();
            this.RdbF = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(218, 207);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(128, 37);
            this.BtnResult.TabIndex = 0;
            this.BtnResult.Text = "결과";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // RdbKor
            // 
            this.RdbKor.AutoSize = true;
            this.RdbKor.Location = new System.Drawing.Point(21, 29);
            this.RdbKor.Name = "RdbKor";
            this.RdbKor.Size = new System.Drawing.Size(71, 16);
            this.RdbKor.TabIndex = 1;
            this.RdbKor.TabStop = true;
            this.RdbKor.Text = "대한민국";
            this.RdbKor.UseVisualStyleBackColor = true;
            // 
            // RdbChi
            // 
            this.RdbChi.AutoSize = true;
            this.RdbChi.Location = new System.Drawing.Point(21, 55);
            this.RdbChi.Name = "RdbChi";
            this.RdbChi.Size = new System.Drawing.Size(47, 16);
            this.RdbChi.TabIndex = 2;
            this.RdbChi.TabStop = true;
            this.RdbChi.Text = "중국";
            this.RdbChi.UseVisualStyleBackColor = true;
            // 
            // RdbJap
            // 
            this.RdbJap.AutoSize = true;
            this.RdbJap.Location = new System.Drawing.Point(21, 81);
            this.RdbJap.Name = "RdbJap";
            this.RdbJap.Size = new System.Drawing.Size(47, 16);
            this.RdbJap.TabIndex = 3;
            this.RdbJap.TabStop = true;
            this.RdbJap.Text = "일본";
            this.RdbJap.UseVisualStyleBackColor = true;
            // 
            // Rdbetc
            // 
            this.Rdbetc.AutoSize = true;
            this.Rdbetc.Location = new System.Drawing.Point(21, 107);
            this.Rdbetc.Name = "Rdbetc";
            this.Rdbetc.Size = new System.Drawing.Size(51, 16);
            this.Rdbetc.TabIndex = 4;
            this.Rdbetc.TabStop = true;
            this.Rdbetc.Text = "그 외";
            this.Rdbetc.UseVisualStyleBackColor = true;
            // 
            // RdbM
            // 
            this.RdbM.AutoSize = true;
            this.RdbM.Location = new System.Drawing.Point(32, 29);
            this.RdbM.Name = "RdbM";
            this.RdbM.Size = new System.Drawing.Size(47, 16);
            this.RdbM.TabIndex = 5;
            this.RdbM.Text = "남자";
            this.RdbM.UseVisualStyleBackColor = true;
            this.RdbM.CheckedChanged += new System.EventHandler(this.RdbM_CheckedChanged);
            // 
            // RdbF
            // 
            this.RdbF.AutoSize = true;
            this.RdbF.Location = new System.Drawing.Point(100, 29);
            this.RdbF.Name = "RdbF";
            this.RdbF.Size = new System.Drawing.Size(47, 16);
            this.RdbF.TabIndex = 6;
            this.RdbF.Text = "여자";
            this.RdbF.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdbKor);
            this.groupBox1.Controls.Add(this.RdbChi);
            this.groupBox1.Controls.Add(this.RdbJap);
            this.groupBox1.Controls.Add(this.Rdbetc);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 134);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "국적";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RdbF);
            this.groupBox2.Controls.Add(this.RdbM);
            this.groupBox2.Location = new System.Drawing.Point(174, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(172, 71);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "성별";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 256);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnResult);
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnResult;
        private System.Windows.Forms.RadioButton RdbKor;
        private System.Windows.Forms.RadioButton RdbChi;
        private System.Windows.Forms.RadioButton RdbJap;
        private System.Windows.Forms.RadioButton Rdbetc;
        private System.Windows.Forms.RadioButton RdbM;
        private System.Windows.Forms.RadioButton RdbF;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

