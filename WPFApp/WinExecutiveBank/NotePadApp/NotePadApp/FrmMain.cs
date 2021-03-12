﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadApp
{
    public partial class FrmMain : Form
    {
        public bool IsModify { get; set; }
        private const string firstFileName = "noname.txt";
        private string currFileName = firstFileName;
        //private string fileName = "noname.txt";
        public FrmMain()
        {
            InitializeComponent();
        }

        private void 파일F0ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MnuNewFile_Click(object sender, EventArgs e)
        {
            //TODO : 만약 작업중인 파일이 있으면 저장처리
            FileProcessSaveFileBeforeClose();
            TxtMain.Text = "";
            IsModify = false;
            currFileName = firstFileName;
        }

        private void FileProcessSaveFileBeforeClose()
        {
            if (IsModify)
            {
                DialogResult answer = MessageBox.Show("변경사항이 있습니다. 저장하시겠습니까?","저장",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (answer == DialogResult.Yes)
                {
                    if (currFileName == firstFileName)
                    {
                        if (DlgSaveText.ShowDialog() == DialogResult.OK)
                        {
                            StreamWriter sw = File.CreateText(DlgSaveText.FileName);
                            sw.WriteLine(TxtMain.Text);
                            sw.Close();
                        }
                        else
                        {
                            StreamWriter sw = File.CreateText(currFileName);
                            sw.WriteLine(TxtMain.Text);
                            sw.Close();
                        }
                    }
                }
            }
        }
        private void MnuOpenFile_Click(object sender, EventArgs e)
        {
            FileProcessSaveFileBeforeClose();

            DlgOpenText.ShowDialog();
            currFileName = DlgOpenText.FileName;
            this.Text = $"{currFileName} - 내 메모장";

            try
            {
                StreamReader sr = File.OpenText(currFileName);
                TxtMain.Text = sr.ReadToEnd();

                IsModify = false;
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MnuSaveFile_Click(object sender, EventArgs e)
        {
            if (currFileName == firstFileName)
            {
                DlgSaveText.Filter = DlgOpenText.Filter ="Text file (*.txt)|*.txt|Log file(*.log)|*.log";
                if (DlgSaveText.ShowDialog() == DialogResult.OK)
                    currFileName = DlgSaveText.FileName;
            }
            StreamWriter sw = File.CreateText(currFileName);
            sw.WriteLine(TxtMain);

            IsModify = false;
            this.Text = $"{currFileName} - 내 메모장";
            sw.Close();
        }

        private void MnuExitFile_Click(object sender, EventArgs e)
        {
            FileProcessSaveFileBeforeClose();
            Environment.Exit(0);
        }

        private void MnuCopy_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                Clipboard.SetDataObject(contents.SelectedText);
                MessageBox.Show(contents.SelectedText);
            }
        }

        private void MnuPaste_Click(object sender, EventArgs e)
        {
            var contents = ActiveControl as RichTextBox;
            if (contents != null)
            {
                IDataObject data = Clipboard.GetDataObject();
                contents.SelectedText = data.GetData(DataFormats.Text).ToString();
                IsModify = true;
            }
        }

        private void MnuAbout_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("메모장");
            var form = new AboutThis();
            form.ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = $"{currFileName} - 내 메모장";
            IsModify = false;
            DlgSaveText.Filter = "Text file (*.txt)|*.txt|Log file(*.log)|*.log";
        }

        private void TxtMain_TextChanged(object sender, EventArgs e)
        {
            IsModify = true;
            this.Text = $"{currFileName}* - 내 메모장";
        }
    }
}
