using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalcApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DtpBirthDay_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime birthday = DtpBirthDay.Value;

            TxtResult.Text = $"{today.Subtract(birthday).TotalDays:#,###}";
            TxtAge.Text = (today.Subtract(birthday).TotalDays / 365).ToString("0");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
