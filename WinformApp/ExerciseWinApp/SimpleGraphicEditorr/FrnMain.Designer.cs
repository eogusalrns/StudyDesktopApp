
namespace SimpleGraphicEditorr
{
    partial class FrnMain
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
            this.TlbMain = new System.Windows.Forms.ToolStrip();
            this.StsMain = new System.Windows.Forms.StatusStrip();
            this.TlmLine = new System.Windows.Forms.ToolStripLabel();
            this.TlmRectangle = new System.Windows.Forms.ToolStripLabel();
            this.TlmCircle = new System.Windows.Forms.ToolStripLabel();
            this.TlmCurve = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TlmColor = new System.Windows.Forms.ToolStripLabel();
            this.StsCurrent = new System.Windows.Forms.ToolStripStatusLabel();
            this.TlbMain.SuspendLayout();
            this.StsMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // TlbMain
            // 
            this.TlbMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TlmLine,
            this.TlmRectangle,
            this.TlmCircle,
            this.TlmCurve,
            this.toolStripSeparator1,
            this.TlmColor});
            this.TlbMain.Location = new System.Drawing.Point(0, 0);
            this.TlbMain.Name = "TlbMain";
            this.TlbMain.Size = new System.Drawing.Size(682, 25);
            this.TlbMain.TabIndex = 2;
            this.TlbMain.Text = "toolStrip1";
            // 
            // StsMain
            // 
            this.StsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.StsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StsCurrent});
            this.StsMain.Location = new System.Drawing.Point(0, 414);
            this.StsMain.Name = "StsMain";
            this.StsMain.Size = new System.Drawing.Size(682, 22);
            this.StsMain.TabIndex = 3;
            this.StsMain.Text = "statusStrip1";
            // 
            // TlmLine
            // 
            this.TlmLine.Name = "TlmLine";
            this.TlmLine.Size = new System.Drawing.Size(19, 22);
            this.TlmLine.Text = "선";
            this.TlmLine.Click += new System.EventHandler(this.TlmLine_Click);
            // 
            // TlmRectangle
            // 
            this.TlmRectangle.Name = "TlmRectangle";
            this.TlmRectangle.Size = new System.Drawing.Size(43, 22);
            this.TlmRectangle.Text = "사각형";
            this.TlmRectangle.Click += new System.EventHandler(this.TlmRectangle_Click);
            // 
            // TlmCircle
            // 
            this.TlmCircle.Name = "TlmCircle";
            this.TlmCircle.Size = new System.Drawing.Size(19, 22);
            this.TlmCircle.Text = "원";
            this.TlmCircle.Click += new System.EventHandler(this.TlmCircle_Click);
            // 
            // TlmCurve
            // 
            this.TlmCurve.Name = "TlmCurve";
            this.TlmCurve.Size = new System.Drawing.Size(31, 22);
            this.TlmCurve.Text = "곡선";
            this.TlmCurve.Click += new System.EventHandler(this.TlmCurve_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TlmColor
            // 
            this.TlmColor.Name = "TlmColor";
            this.TlmColor.Size = new System.Drawing.Size(31, 22);
            this.TlmColor.Text = "색깔";
            this.TlmColor.Click += new System.EventHandler(this.TlmColor_Click);
            // 
            // StsCurrent
            // 
            this.StsCurrent.Name = "StsCurrent";
            this.StsCurrent.Size = new System.Drawing.Size(121, 17);
            this.StsCurrent.Text = "toolStripStatusLabel1";
            // 
            // FrnMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 436);
            this.Controls.Add(this.StsMain);
            this.Controls.Add(this.TlbMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrnMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "그래픽 에디터";
            this.Load += new System.EventHandler(this.FrnMain_Load);
            this.TlbMain.ResumeLayout(false);
            this.TlbMain.PerformLayout();
            this.StsMain.ResumeLayout(false);
            this.StsMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TlbMain;
        private System.Windows.Forms.ToolStripLabel TlmLine;
        private System.Windows.Forms.ToolStripLabel TlmRectangle;
        private System.Windows.Forms.ToolStripLabel TlmCircle;
        private System.Windows.Forms.ToolStripLabel TlmCurve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel TlmColor;
        private System.Windows.Forms.StatusStrip StsMain;
        private System.Windows.Forms.ToolStripStatusLabel StsCurrent;
    }
}

