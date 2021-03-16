
namespace IotSensorMonApp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ChtPhotoResistors = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.BtnCon = new System.Windows.Forms.Button();
            this.BtnDiscon = new System.Windows.Forms.Button();
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.BtnViewAll = new System.Windows.Forms.Button();
            this.BtnZoom = new System.Windows.Forms.Button();
            this.LsbPhotoResistors = new System.Windows.Forms.ListBox();
            this.PrbPhotoResistor = new System.Windows.Forms.ProgressBar();
            this.파일FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLoadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.시뮬레이션SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStartSimul = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEndSimul = new System.Windows.Forms.ToolStripMenuItem();
            this.LblConnectTime = new System.Windows.Forms.Label();
            this.TxtSensorNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbSerialPort = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtPhotoResistors)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일FToolStripMenuItem,
            this.시뮬레이션SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ChtPhotoResistors
            // 
            chartArea1.Name = "ChartArea1";
            this.ChtPhotoResistors.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChtPhotoResistors.Legends.Add(legend1);
            this.ChtPhotoResistors.Location = new System.Drawing.Point(12, 284);
            this.ChtPhotoResistors.Name = "ChtPhotoResistors";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChtPhotoResistors.Series.Add(series1);
            this.ChtPhotoResistors.Size = new System.Drawing.Size(460, 259);
            this.ChtPhotoResistors.TabIndex = 1;
            this.ChtPhotoResistors.Text = "chart1";
            // 
            // BtnCon
            // 
            this.BtnCon.Location = new System.Drawing.Point(6, 64);
            this.BtnCon.Name = "BtnCon";
            this.BtnCon.Size = new System.Drawing.Size(91, 23);
            this.BtnCon.TabIndex = 2;
            this.BtnCon.Text = "Connect";
            this.BtnCon.UseVisualStyleBackColor = true;
            this.BtnCon.Click += new System.EventHandler(this.BtnCon_Click);
            // 
            // BtnDiscon
            // 
            this.BtnDiscon.Location = new System.Drawing.Point(6, 98);
            this.BtnDiscon.Name = "BtnDiscon";
            this.BtnDiscon.Size = new System.Drawing.Size(91, 23);
            this.BtnDiscon.TabIndex = 3;
            this.BtnDiscon.Text = "Disconnect";
            this.BtnDiscon.UseVisualStyleBackColor = true;
            this.BtnDiscon.Click += new System.EventHandler(this.BtnDiscon_Click);
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnDisplay.Location = new System.Drawing.Point(6, 133);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(91, 94);
            this.BtnDisplay.TabIndex = 4;
            this.BtnDisplay.Text = "COM";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            // 
            // BtnViewAll
            // 
            this.BtnViewAll.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnViewAll.Location = new System.Drawing.Point(156, 549);
            this.BtnViewAll.Name = "BtnViewAll";
            this.BtnViewAll.Size = new System.Drawing.Size(75, 50);
            this.BtnViewAll.TabIndex = 5;
            this.BtnViewAll.Text = "View All";
            this.BtnViewAll.UseVisualStyleBackColor = true;
            this.BtnViewAll.Click += new System.EventHandler(this.BtnViewAll_Click);
            // 
            // BtnZoom
            // 
            this.BtnZoom.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnZoom.Location = new System.Drawing.Point(237, 549);
            this.BtnZoom.Name = "BtnZoom";
            this.BtnZoom.Size = new System.Drawing.Size(75, 50);
            this.BtnZoom.TabIndex = 6;
            this.BtnZoom.Text = "Zoom";
            this.BtnZoom.UseVisualStyleBackColor = true;
            this.BtnZoom.Click += new System.EventHandler(this.BtnZoom_Click);
            // 
            // LsbPhotoResistors
            // 
            this.LsbPhotoResistors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LsbPhotoResistors.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LsbPhotoResistors.FormattingEnabled = true;
            this.LsbPhotoResistors.ItemHeight = 15;
            this.LsbPhotoResistors.Location = new System.Drawing.Point(12, 173);
            this.LsbPhotoResistors.Name = "LsbPhotoResistors";
            this.LsbPhotoResistors.ScrollAlwaysVisible = true;
            this.LsbPhotoResistors.Size = new System.Drawing.Size(351, 92);
            this.LsbPhotoResistors.TabIndex = 7;
            // 
            // PrbPhotoResistor
            // 
            this.PrbPhotoResistor.Location = new System.Drawing.Point(8, 37);
            this.PrbPhotoResistor.Maximum = 1023;
            this.PrbPhotoResistor.Name = "PrbPhotoResistor";
            this.PrbPhotoResistor.Size = new System.Drawing.Size(337, 23);
            this.PrbPhotoResistor.TabIndex = 8;
            // 
            // 파일FToolStripMenuItem
            // 
            this.파일FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLoadFile,
            this.MnuSaveFile,
            this.toolStripSeparator1,
            this.MnuExit});
            this.파일FToolStripMenuItem.Name = "파일FToolStripMenuItem";
            this.파일FToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.파일FToolStripMenuItem.Text = "파일(&F)";
            // 
            // MnuLoadFile
            // 
            this.MnuLoadFile.Name = "MnuLoadFile";
            this.MnuLoadFile.Size = new System.Drawing.Size(180, 22);
            this.MnuLoadFile.Text = "읽어오기(&O)";
            // 
            // MnuSaveFile
            // 
            this.MnuSaveFile.Name = "MnuSaveFile";
            this.MnuSaveFile.Size = new System.Drawing.Size(180, 22);
            this.MnuSaveFile.Text = "저장하기(&S)";
            // 
            // MnuExit
            // 
            this.MnuExit.Name = "MnuExit";
            this.MnuExit.Size = new System.Drawing.Size(180, 22);
            this.MnuExit.Text = "종료(&X)";
            this.MnuExit.Click += new System.EventHandler(this.MnuExit_Click);
            // 
            // 시뮬레이션SToolStripMenuItem
            // 
            this.시뮬레이션SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStartSimul,
            this.MnuEndSimul});
            this.시뮬레이션SToolStripMenuItem.Name = "시뮬레이션SToolStripMenuItem";
            this.시뮬레이션SToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.시뮬레이션SToolStripMenuItem.Text = "시뮬레이션(&S)";
            // 
            // MnuStartSimul
            // 
            this.MnuStartSimul.Name = "MnuStartSimul";
            this.MnuStartSimul.Size = new System.Drawing.Size(180, 22);
            this.MnuStartSimul.Text = "시작(&B)";
            this.MnuStartSimul.Click += new System.EventHandler(this.MnuStartSimul_Click);
            // 
            // MnuEndSimul
            // 
            this.MnuEndSimul.Name = "MnuEndSimul";
            this.MnuEndSimul.Size = new System.Drawing.Size(180, 22);
            this.MnuEndSimul.Text = "끝(&E)";
            this.MnuEndSimul.Click += new System.EventHandler(this.MnuEndSimul_Click);
            // 
            // LblConnectTime
            // 
            this.LblConnectTime.AutoSize = true;
            this.LblConnectTime.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LblConnectTime.Location = new System.Drawing.Point(18, 43);
            this.LblConnectTime.Name = "LblConnectTime";
            this.LblConnectTime.Size = new System.Drawing.Size(228, 15);
            this.LblConnectTime.TabIndex = 9;
            this.LblConnectTime.Text = "Connection Time : 2021-03-16 10:33:34";
            // 
            // TxtSensorNumber
            // 
            this.TxtSensorNumber.Location = new System.Drawing.Point(252, 40);
            this.TxtSensorNumber.Name = "TxtSensorNumber";
            this.TxtSensorNumber.ReadOnly = true;
            this.TxtSensorNumber.Size = new System.Drawing.Size(100, 21);
            this.TxtSensorNumber.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.PrbPhotoResistor);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 100);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PhotoResistor";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "1023";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbSerialPort);
            this.groupBox2.Controls.Add(this.BtnCon);
            this.groupBox2.Controls.Add(this.BtnDiscon);
            this.groupBox2.Controls.Add(this.BtnDisplay);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox2.Location = new System.Drawing.Point(369, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 233);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Port";
            // 
            // CmbSerialPort
            // 
            this.CmbSerialPort.FormattingEnabled = true;
            this.CmbSerialPort.Location = new System.Drawing.Point(6, 27);
            this.CmbSerialPort.Name = "CmbSerialPort";
            this.CmbSerialPort.Size = new System.Drawing.Size(91, 23);
            this.CmbSerialPort.TabIndex = 5;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TxtSensorNumber);
            this.Controls.Add(this.LblConnectTime);
            this.Controls.Add(this.LsbPhotoResistors);
            this.Controls.Add(this.BtnZoom);
            this.Controls.Add(this.BtnViewAll);
            this.Controls.Add(this.ChtPhotoResistors);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoT Photoresistor Monitoring";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChtPhotoResistors)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuLoadFile;
        private System.Windows.Forms.ToolStripMenuItem MnuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem MnuExit;
        private System.Windows.Forms.ToolStripMenuItem 시뮬레이션SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStartSimul;
        private System.Windows.Forms.ToolStripMenuItem MnuEndSimul;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChtPhotoResistors;
        private System.Windows.Forms.Button BtnCon;
        private System.Windows.Forms.Button BtnDiscon;
        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.Button BtnViewAll;
        private System.Windows.Forms.Button BtnZoom;
        private System.Windows.Forms.ListBox LsbPhotoResistors;
        private System.Windows.Forms.ProgressBar PrbPhotoResistor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label LblConnectTime;
        private System.Windows.Forms.TextBox TxtSensorNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbSerialPort;
    }
}

