﻿
namespace BookRentalShop
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.구분코드CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.회원PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도서BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.대여관리RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.종료XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.관리ToolStripMenuItem,
            this.종료XToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(960, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.구분코드CToolStripMenuItem,
            this.회원PToolStripMenuItem,
            this.도서BToolStripMenuItem,
            this.toolStripMenuItem1,
            this.대여관리RToolStripMenuItem});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.관리ToolStripMenuItem.Text = "관리(&M)";
            // 
            // 구분코드CToolStripMenuItem
            // 
            this.구분코드CToolStripMenuItem.Name = "구분코드CToolStripMenuItem";
            this.구분코드CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.구분코드CToolStripMenuItem.Text = "구분코드(&C)";
            // 
            // 회원PToolStripMenuItem
            // 
            this.회원PToolStripMenuItem.Name = "회원PToolStripMenuItem";
            this.회원PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.회원PToolStripMenuItem.Text = "회원(&P)";
            // 
            // 도서BToolStripMenuItem
            // 
            this.도서BToolStripMenuItem.Name = "도서BToolStripMenuItem";
            this.도서BToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.도서BToolStripMenuItem.Text = "도서(&B)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // 대여관리RToolStripMenuItem
            // 
            this.대여관리RToolStripMenuItem.Name = "대여관리RToolStripMenuItem";
            this.대여관리RToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.대여관리RToolStripMenuItem.Text = "대여관리(&R)";
            // 
            // 종료XToolStripMenuItem
            // 
            this.종료XToolStripMenuItem.Name = "종료XToolStripMenuItem";
            this.종료XToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.종료XToolStripMenuItem.Text = "종료(&X)";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "책 대여점 프로그램";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FrmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 구분코드CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 회원PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도서BToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 대여관리RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 종료XToolStripMenuItem;
    }
}

