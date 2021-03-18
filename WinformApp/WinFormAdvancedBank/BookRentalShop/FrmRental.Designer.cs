
namespace BookRentalShop
{
    partial class FrmRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRental));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DtpRentalDate = new MetroFramework.Controls.MetroDateTime();
            this.TxtBookNames = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.TxtMemberName = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.BtnSearchMember = new System.Windows.Forms.Button();
            this.BtnSearchBook = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.CboRentalState = new MetroFramework.Controls.MetroComboBox();
            this.TxtReturnDate = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.TxtReturnDate);
            this.groupBox1.Controls.Add(this.CboRentalState);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.BtnSearchBook);
            this.groupBox1.Controls.Add(this.BtnSearchMember);
            this.groupBox1.Controls.Add(this.DtpRentalDate);
            this.groupBox1.Controls.Add(this.TxtBookNames);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.TxtMemberName);
            this.groupBox1.Controls.Add(this.TxtIdx);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Location = new System.Drawing.Point(369, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 466);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "상세";
            // 
            // DtpRentalDate
            // 
            this.DtpRentalDate.CustomFormat = "yyyy-MM-dd";
            this.DtpRentalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpRentalDate.Location = new System.Drawing.Point(112, 162);
            this.DtpRentalDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpRentalDate.Name = "DtpRentalDate";
            this.DtpRentalDate.Size = new System.Drawing.Size(207, 29);
            this.DtpRentalDate.TabIndex = 4;
            // 
            // TxtBookNames
            // 
            // 
            // 
            // 
            this.TxtBookNames.CustomButton.Image = null;
            this.TxtBookNames.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.TxtBookNames.CustomButton.Name = "";
            this.TxtBookNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBookNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookNames.CustomButton.TabIndex = 1;
            this.TxtBookNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookNames.CustomButton.UseSelectable = true;
            this.TxtBookNames.CustomButton.Visible = false;
            this.TxtBookNames.Lines = new string[0];
            this.TxtBookNames.Location = new System.Drawing.Point(112, 122);
            this.TxtBookNames.MaxLength = 32767;
            this.TxtBookNames.Name = "TxtBookNames";
            this.TxtBookNames.PasswordChar = '\0';
            this.TxtBookNames.PromptText = "도서명";
            this.TxtBookNames.ReadOnly = true;
            this.TxtBookNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookNames.SelectedText = "";
            this.TxtBookNames.SelectionLength = 0;
            this.TxtBookNames.SelectionStart = 0;
            this.TxtBookNames.ShortcutsEnabled = true;
            this.TxtBookNames.Size = new System.Drawing.Size(144, 23);
            this.TxtBookNames.TabIndex = 3;
            this.TxtBookNames.UseSelectable = true;
            this.TxtBookNames.WaterMark = "도서명";
            this.TxtBookNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(45, 162);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "대여일 : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(41, 122);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "도서명 :  ";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(274, 428);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "저장";
            this.BtnSave.UseSelectable = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNew.Location = new System.Drawing.Point(193, 428);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(75, 23);
            this.BtnNew.TabIndex = 8;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // TxtMemberName
            // 
            // 
            // 
            // 
            this.TxtMemberName.CustomButton.Image = null;
            this.TxtMemberName.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.TxtMemberName.CustomButton.Name = "";
            this.TxtMemberName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtMemberName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtMemberName.CustomButton.TabIndex = 1;
            this.TxtMemberName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtMemberName.CustomButton.UseSelectable = true;
            this.TxtMemberName.CustomButton.Visible = false;
            this.TxtMemberName.Lines = new string[0];
            this.TxtMemberName.Location = new System.Drawing.Point(112, 82);
            this.TxtMemberName.MaxLength = 32767;
            this.TxtMemberName.Name = "TxtMemberName";
            this.TxtMemberName.PasswordChar = '\0';
            this.TxtMemberName.PromptText = "대여회원";
            this.TxtMemberName.ReadOnly = true;
            this.TxtMemberName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtMemberName.SelectedText = "";
            this.TxtMemberName.SelectionLength = 0;
            this.TxtMemberName.SelectionStart = 0;
            this.TxtMemberName.ShortcutsEnabled = true;
            this.TxtMemberName.Size = new System.Drawing.Size(144, 23);
            this.TxtMemberName.TabIndex = 2;
            this.TxtMemberName.UseSelectable = true;
            this.TxtMemberName.WaterMark = "대여회원";
            this.TxtMemberName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtMemberName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtIdx
            // 
            // 
            // 
            // 
            this.TxtIdx.CustomButton.Image = null;
            this.TxtIdx.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TxtIdx.CustomButton.Name = "";
            this.TxtIdx.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtIdx.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtIdx.CustomButton.TabIndex = 1;
            this.TxtIdx.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtIdx.CustomButton.UseSelectable = true;
            this.TxtIdx.CustomButton.Visible = false;
            this.TxtIdx.Lines = new string[0];
            this.TxtIdx.Location = new System.Drawing.Point(112, 42);
            this.TxtIdx.MaxLength = 32767;
            this.TxtIdx.Name = "TxtIdx";
            this.TxtIdx.PasswordChar = '\0';
            this.TxtIdx.PromptText = "순번";
            this.TxtIdx.ReadOnly = true;
            this.TxtIdx.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtIdx.SelectedText = "";
            this.TxtIdx.SelectionLength = 0;
            this.TxtIdx.SelectionStart = 0;
            this.TxtIdx.ShortcutsEnabled = true;
            this.TxtIdx.Size = new System.Drawing.Size(207, 23);
            this.TxtIdx.TabIndex = 1;
            this.TxtIdx.UseSelectable = true;
            this.TxtIdx.WaterMark = "순번";
            this.TxtIdx.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtIdx.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(31, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "대여회원 : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(59, 42);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "순번 : ";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Location = new System.Drawing.Point(24, 63);
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.RowTemplate.Height = 23;
            this.DgvData.Size = new System.Drawing.Size(339, 466);
            this.DgvData.TabIndex = 1;
            this.DgvData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellClick);
            // 
            // BtnSearchMember
            // 
            this.BtnSearchMember.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchMember.Image")));
            this.BtnSearchMember.Location = new System.Drawing.Point(262, 82);
            this.BtnSearchMember.Name = "BtnSearchMember";
            this.BtnSearchMember.Size = new System.Drawing.Size(57, 23);
            this.BtnSearchMember.TabIndex = 13;
            this.BtnSearchMember.Text = "...";
            this.BtnSearchMember.UseVisualStyleBackColor = true;
            this.BtnSearchMember.Click += new System.EventHandler(this.BtnSearchMember_Click);
            // 
            // BtnSearchBook
            // 
            this.BtnSearchBook.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearchBook.Image")));
            this.BtnSearchBook.Location = new System.Drawing.Point(262, 122);
            this.BtnSearchBook.Name = "BtnSearchBook";
            this.BtnSearchBook.Size = new System.Drawing.Size(57, 23);
            this.BtnSearchBook.TabIndex = 14;
            this.BtnSearchBook.Text = "...";
            this.BtnSearchBook.UseVisualStyleBackColor = true;
            this.BtnSearchBook.Click += new System.EventHandler(this.BtnSearchBook_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(45, 202);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 19);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "반납일 : ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(31, 242);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(76, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "대여상태 : ";
            // 
            // CboRentalState
            // 
            this.CboRentalState.FormattingEnabled = true;
            this.CboRentalState.ItemHeight = 23;
            this.CboRentalState.Location = new System.Drawing.Point(112, 242);
            this.CboRentalState.Name = "CboRentalState";
            this.CboRentalState.Size = new System.Drawing.Size(86, 29);
            this.CboRentalState.TabIndex = 6;
            this.CboRentalState.UseSelectable = true;
            // 
            // TxtReturnDate
            // 
            // 
            // 
            // 
            this.TxtReturnDate.CustomButton.Image = null;
            this.TxtReturnDate.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.TxtReturnDate.CustomButton.Name = "";
            this.TxtReturnDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtReturnDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtReturnDate.CustomButton.TabIndex = 1;
            this.TxtReturnDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtReturnDate.CustomButton.UseSelectable = true;
            this.TxtReturnDate.CustomButton.Visible = false;
            this.TxtReturnDate.Lines = new string[0];
            this.TxtReturnDate.Location = new System.Drawing.Point(114, 202);
            this.TxtReturnDate.MaxLength = 32767;
            this.TxtReturnDate.Name = "TxtReturnDate";
            this.TxtReturnDate.PasswordChar = '\0';
            this.TxtReturnDate.ReadOnly = true;
            this.TxtReturnDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtReturnDate.SelectedText = "";
            this.TxtReturnDate.SelectionLength = 0;
            this.TxtReturnDate.SelectionStart = 0;
            this.TxtReturnDate.ShortcutsEnabled = true;
            this.TxtReturnDate.Size = new System.Drawing.Size(205, 23);
            this.TxtReturnDate.TabIndex = 18;
            this.TxtReturnDate.UseSelectable = true;
            this.TxtReturnDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtReturnDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 552);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRental";
            this.Text = "대여 관리";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDivCode_Load);
            this.Resize += new System.EventHandler(this.FrmDivCode_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton BtnSave;
        private MetroFramework.Controls.MetroButton BtnNew;
        private MetroFramework.Controls.MetroTextBox TxtMemberName;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtBookNames;
        private MetroFramework.Controls.MetroDateTime DtpRentalDate;
        private System.Windows.Forms.Button BtnSearchBook;
        private System.Windows.Forms.Button BtnSearchMember;
        private MetroFramework.Controls.MetroComboBox CboRentalState;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtReturnDate;
    }
}