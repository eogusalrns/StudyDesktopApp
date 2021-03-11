using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextViewerApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            DlgSelect.FileName = "Select a text file";
            DlgSelect.Filter = "Text files (*.txt)|*.txt";
            DlgSelect.Title = "Open text file";
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if (DlgSelect.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = DlgSelect.FileName;

                    using (FileStream fs = File.Open(filePath, FileMode.Open))
                    {
                        Process.Start("Notepad++.exe", filePath);
                    }
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"{ex.Message}");
                    throw;
                }
            }
        }
    }
}
