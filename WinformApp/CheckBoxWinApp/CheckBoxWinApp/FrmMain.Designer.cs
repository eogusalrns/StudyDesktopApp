
namespace CheckBoxWinApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.ChkMelon = new System.Windows.Forms.CheckBox();
            this.ChkBanana = new System.Windows.Forms.CheckBox();
            this.ChkApple = new System.Windows.Forms.CheckBox();
            this.ChkWatemelon = new System.Windows.Forms.CheckBox();
            this.ChkKoreammelon = new System.Windows.Forms.CheckBox();
            this.ChkStrawberry = new System.Windows.Forms.CheckBox();
            this.BtnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "질문 : 좋아하는 과일을 모두 선택하세요";
            // 
            // ChkMelon
            // 
            this.ChkMelon.AutoSize = true;
            this.ChkMelon.Location = new System.Drawing.Point(12, 54);
            this.ChkMelon.Name = "ChkMelon";
            this.ChkMelon.Size = new System.Drawing.Size(48, 16);
            this.ChkMelon.TabIndex = 2;
            this.ChkMelon.Text = "메론";
            this.ChkMelon.UseVisualStyleBackColor = true;
            // 
            // ChkBanana
            // 
            this.ChkBanana.AutoSize = true;
            this.ChkBanana.Location = new System.Drawing.Point(12, 75);
            this.ChkBanana.Name = "ChkBanana";
            this.ChkBanana.Size = new System.Drawing.Size(60, 16);
            this.ChkBanana.TabIndex = 3;
            this.ChkBanana.Text = "바나나";
            this.ChkBanana.UseVisualStyleBackColor = true;
            // 
            // ChkApple
            // 
            this.ChkApple.AutoSize = true;
            this.ChkApple.Location = new System.Drawing.Point(12, 96);
            this.ChkApple.Name = "ChkApple";
            this.ChkApple.Size = new System.Drawing.Size(48, 16);
            this.ChkApple.TabIndex = 4;
            this.ChkApple.Text = "사과";
            this.ChkApple.UseVisualStyleBackColor = true;
            // 
            // ChkWatemelon
            // 
            this.ChkWatemelon.AutoSize = true;
            this.ChkWatemelon.Location = new System.Drawing.Point(12, 117);
            this.ChkWatemelon.Name = "ChkWatemelon";
            this.ChkWatemelon.Size = new System.Drawing.Size(48, 16);
            this.ChkWatemelon.TabIndex = 5;
            this.ChkWatemelon.Text = "수박";
            this.ChkWatemelon.UseVisualStyleBackColor = true;
            this.ChkWatemelon.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // ChkKoreammelon
            // 
            this.ChkKoreammelon.AutoSize = true;
            this.ChkKoreammelon.Location = new System.Drawing.Point(12, 138);
            this.ChkKoreammelon.Name = "ChkKoreammelon";
            this.ChkKoreammelon.Size = new System.Drawing.Size(48, 16);
            this.ChkKoreammelon.TabIndex = 6;
            this.ChkKoreammelon.Text = "참외";
            this.ChkKoreammelon.UseVisualStyleBackColor = true;
            // 
            // ChkStrawberry
            // 
            this.ChkStrawberry.AutoSize = true;
            this.ChkStrawberry.Location = new System.Drawing.Point(12, 159);
            this.ChkStrawberry.Name = "ChkStrawberry";
            this.ChkStrawberry.Size = new System.Drawing.Size(48, 16);
            this.ChkStrawberry.TabIndex = 7;
            this.ChkStrawberry.Text = "딸기";
            this.ChkStrawberry.UseVisualStyleBackColor = true;
            // 
            // BtnResult
            // 
            this.BtnResult.Location = new System.Drawing.Point(348, 138);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(87, 37);
            this.BtnResult.TabIndex = 8;
            this.BtnResult.Text = "결과";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 186);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.ChkStrawberry);
            this.Controls.Add(this.ChkKoreammelon);
            this.Controls.Add(this.ChkWatemelon);
            this.Controls.Add(this.ChkApple);
            this.Controls.Add(this.ChkBanana);
            this.Controls.Add(this.ChkMelon);
            this.Controls.Add(this.label1);
            this.Name = "FrmMain";
            this.Text = "Favorite Fruits App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkMelon;
        private System.Windows.Forms.CheckBox ChkBanana;
        private System.Windows.Forms.CheckBox ChkApple;
        private System.Windows.Forms.CheckBox ChkWatemelon;
        private System.Windows.Forms.CheckBox ChkKoreammelon;
        private System.Windows.Forms.CheckBox ChkStrawberry;
        private System.Windows.Forms.Button BtnResult;
    }
}

