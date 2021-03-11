using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePlayApp
{
    public partial class FrmPlayer : Form
    {
        public FrmPlayer()
        {
            InitializeComponent();
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            if ( DlgSelect.ShowDialog() == DialogResult.OK)
            {
                MyPlayer.URL = DlgSelect.FileName;
            }
        }

        private void FrmPlayer_Load(object sender, EventArgs e)
        {
            MyPlayer.stretchToFit = true;
        }
    }
}
