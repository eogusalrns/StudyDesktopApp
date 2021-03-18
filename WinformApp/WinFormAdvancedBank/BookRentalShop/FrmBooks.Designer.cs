
namespace BookRentalShop
{
    partial class FrmBooks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CboDivision = new MetroFramework.Controls.MetroComboBox();
            this.TxtDescriptions = new MetroFramework.Controls.MetroTextBox();
            this.TxtPrice = new MetroFramework.Controls.MetroTextBox();
            this.TxtISBN = new MetroFramework.Controls.MetroTextBox();
            this.TxtBookNames = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.BtnSave = new MetroFramework.Controls.MetroButton();
            this.BtnNew = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.TxtAuthor = new MetroFramework.Controls.MetroTextBox();
            this.TxtIdx = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.DtpReleaseDate = new MetroFramework.Controls.MetroDateTime();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DtpReleaseDate);
            this.groupBox1.Controls.Add(this.CboDivision);
            this.groupBox1.Controls.Add(this.TxtDescriptions);
            this.groupBox1.Controls.Add(this.TxtPrice);
            this.groupBox1.Controls.Add(this.TxtISBN);
            this.groupBox1.Controls.Add(this.TxtBookNames);
            this.groupBox1.Controls.Add(this.metroLabel7);
            this.groupBox1.Controls.Add(this.metroLabel8);
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.BtnSave);
            this.groupBox1.Controls.Add(this.BtnNew);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.TxtAuthor);
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
            // CboDivision
            // 
            this.CboDivision.FormattingEnabled = true;
            this.CboDivision.ItemHeight = 23;
            this.CboDivision.Location = new System.Drawing.Point(112, 122);
            this.CboDivision.Name = "CboDivision";
            this.CboDivision.PromptText = "장르";
            this.CboDivision.Size = new System.Drawing.Size(104, 29);
            this.CboDivision.TabIndex = 3;
            this.CboDivision.UseSelectable = true;
            // 
            // TxtDescriptions
            // 
            this.TxtDescriptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.TxtDescriptions.CustomButton.Image = null;
            this.TxtDescriptions.CustomButton.Location = new System.Drawing.Point(109, 2);
            this.TxtDescriptions.CustomButton.Name = "";
            this.TxtDescriptions.CustomButton.Size = new System.Drawing.Size(95, 95);
            this.TxtDescriptions.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDescriptions.CustomButton.TabIndex = 1;
            this.TxtDescriptions.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDescriptions.CustomButton.UseSelectable = true;
            this.TxtDescriptions.CustomButton.Visible = false;
            this.TxtDescriptions.Lines = new string[0];
            this.TxtDescriptions.Location = new System.Drawing.Point(112, 322);
            this.TxtDescriptions.MaxLength = 32767;
            this.TxtDescriptions.Multiline = true;
            this.TxtDescriptions.Name = "TxtDescriptions";
            this.TxtDescriptions.PasswordChar = '\0';
            this.TxtDescriptions.PromptText = "설명";
            this.TxtDescriptions.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDescriptions.SelectedText = "";
            this.TxtDescriptions.SelectionLength = 0;
            this.TxtDescriptions.SelectionStart = 0;
            this.TxtDescriptions.ShortcutsEnabled = true;
            this.TxtDescriptions.Size = new System.Drawing.Size(207, 100);
            this.TxtDescriptions.TabIndex = 8;
            this.TxtDescriptions.UseSelectable = true;
            this.TxtDescriptions.WaterMark = "설명";
            this.TxtDescriptions.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDescriptions.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPrice
            // 
            // 
            // 
            // 
            this.TxtPrice.CustomButton.Image = null;
            this.TxtPrice.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TxtPrice.CustomButton.Name = "";
            this.TxtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPrice.CustomButton.TabIndex = 1;
            this.TxtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPrice.CustomButton.UseSelectable = true;
            this.TxtPrice.CustomButton.Visible = false;
            this.TxtPrice.Lines = new string[0];
            this.TxtPrice.Location = new System.Drawing.Point(112, 282);
            this.TxtPrice.MaxLength = 32767;
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.PasswordChar = '\0';
            this.TxtPrice.PromptText = "가격";
            this.TxtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPrice.SelectedText = "";
            this.TxtPrice.SelectionLength = 0;
            this.TxtPrice.SelectionStart = 0;
            this.TxtPrice.ShortcutsEnabled = true;
            this.TxtPrice.Size = new System.Drawing.Size(207, 23);
            this.TxtPrice.TabIndex = 7;
            this.TxtPrice.UseSelectable = true;
            this.TxtPrice.WaterMark = "가격";
            this.TxtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtPrice.Click += new System.EventHandler(this.TxtId_Click);
            // 
            // TxtISBN
            // 
            // 
            // 
            // 
            this.TxtISBN.CustomButton.Image = null;
            this.TxtISBN.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TxtISBN.CustomButton.Name = "";
            this.TxtISBN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtISBN.CustomButton.TabIndex = 1;
            this.TxtISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtISBN.CustomButton.UseSelectable = true;
            this.TxtISBN.CustomButton.Visible = false;
            this.TxtISBN.Lines = new string[0];
            this.TxtISBN.Location = new System.Drawing.Point(112, 242);
            this.TxtISBN.MaxLength = 32767;
            this.TxtISBN.Name = "TxtISBN";
            this.TxtISBN.PasswordChar = '\0';
            this.TxtISBN.PromptText = "ISBN";
            this.TxtISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtISBN.SelectedText = "";
            this.TxtISBN.SelectionLength = 0;
            this.TxtISBN.SelectionStart = 0;
            this.TxtISBN.ShortcutsEnabled = true;
            this.TxtISBN.Size = new System.Drawing.Size(207, 23);
            this.TxtISBN.TabIndex = 6;
            this.TxtISBN.UseSelectable = true;
            this.TxtISBN.WaterMark = "ISBN";
            this.TxtISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtBookNames
            // 
            // 
            // 
            // 
            this.TxtBookNames.CustomButton.Image = null;
            this.TxtBookNames.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TxtBookNames.CustomButton.Name = "";
            this.TxtBookNames.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtBookNames.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtBookNames.CustomButton.TabIndex = 1;
            this.TxtBookNames.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtBookNames.CustomButton.UseSelectable = true;
            this.TxtBookNames.CustomButton.Visible = false;
            this.TxtBookNames.Lines = new string[0];
            this.TxtBookNames.Location = new System.Drawing.Point(112, 162);
            this.TxtBookNames.MaxLength = 32767;
            this.TxtBookNames.Name = "TxtBookNames";
            this.TxtBookNames.PasswordChar = '\0';
            this.TxtBookNames.PromptText = "도서명";
            this.TxtBookNames.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtBookNames.SelectedText = "";
            this.TxtBookNames.SelectionLength = 0;
            this.TxtBookNames.SelectionStart = 0;
            this.TxtBookNames.ShortcutsEnabled = true;
            this.TxtBookNames.Size = new System.Drawing.Size(207, 23);
            this.TxtBookNames.TabIndex = 4;
            this.TxtBookNames.UseSelectable = true;
            this.TxtBookNames.WaterMark = "도서명";
            this.TxtBookNames.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtBookNames.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(49, 322);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(48, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = "설명 : ";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(49, 282);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "가격 : ";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Location = new System.Drawing.Point(35, 242);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "ISBN : ";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(35, 202);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "출판일 : ";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(31, 162);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(66, 19);
            this.metroLabel3.TabIndex = 9;
            this.metroLabel3.Text = "도서명 :  ";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(49, 122);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(48, 19);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "장르 : ";
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSave.Location = new System.Drawing.Point(274, 428);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 11;
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
            this.BtnNew.TabIndex = 10;
            this.BtnNew.Text = "신규";
            this.BtnNew.UseSelectable = true;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(112, 428);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "삭제";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // TxtAuthor
            // 
            // 
            // 
            // 
            this.TxtAuthor.CustomButton.Image = null;
            this.TxtAuthor.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TxtAuthor.CustomButton.Name = "";
            this.TxtAuthor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAuthor.CustomButton.TabIndex = 1;
            this.TxtAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAuthor.CustomButton.UseSelectable = true;
            this.TxtAuthor.CustomButton.Visible = false;
            this.TxtAuthor.Lines = new string[0];
            this.TxtAuthor.Location = new System.Drawing.Point(112, 82);
            this.TxtAuthor.MaxLength = 32767;
            this.TxtAuthor.Name = "TxtAuthor";
            this.TxtAuthor.PasswordChar = '\0';
            this.TxtAuthor.PromptText = "저자";
            this.TxtAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAuthor.SelectedText = "";
            this.TxtAuthor.SelectionLength = 0;
            this.TxtAuthor.SelectionStart = 0;
            this.TxtAuthor.ShortcutsEnabled = true;
            this.TxtAuthor.Size = new System.Drawing.Size(207, 23);
            this.TxtAuthor.TabIndex = 2;
            this.TxtAuthor.UseSelectable = true;
            this.TxtAuthor.WaterMark = "저자";
            this.TxtAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.metroLabel2.Location = new System.Drawing.Point(49, 82);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(48, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "저자 : ";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 42);
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
            this.DgvData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellContentClick);
            // 
            // DtpReleaseDate
            // 
            this.DtpReleaseDate.Location = new System.Drawing.Point(112, 202);
            this.DtpReleaseDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.DtpReleaseDate.Name = "DtpReleaseDate";
            this.DtpReleaseDate.Size = new System.Drawing.Size(207, 29);
            this.DtpReleaseDate.TabIndex = 5;
            // 
            // FrmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 552);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmBooks";
            this.Text = "책 관리";
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
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroTextBox TxtAuthor;
        private MetroFramework.Controls.MetroTextBox TxtIdx;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridView DgvData;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox TxtDescriptions;
        private MetroFramework.Controls.MetroTextBox TxtPrice;
        private MetroFramework.Controls.MetroTextBox TxtISBN;
        private MetroFramework.Controls.MetroTextBox TxtBookNames;
        private MetroFramework.Controls.MetroComboBox CboDivision;
        private MetroFramework.Controls.MetroDateTime DtpReleaseDate;
    }
}