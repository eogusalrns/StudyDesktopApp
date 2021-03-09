using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            string result = string.Empty;
            if (RdbKor.Checked == false && RdbChi.Checked == false &&
                RdbJap.Checked == false && Rdbetc.Checked == false)
            {
                MessageBox.Show("국가를 선택하세요.");
                return;
            }

            if (RdbM.Checked == false && RdbF.Checked == false )
            {
                MessageBox.Show("성별을 선택하세요.");
                return;
            }


            if (RdbKor.Checked)
                result = "국적 : 대한민국\n";
            else if (RdbChi.Checked)
                result = "국적 : 중국\n";
            else if (RdbJap.Checked)
                result = "국적 : 일본\n";
            else if (Rdbetc.Checked)
                result = "국적 : 미상\n";

            if (RdbM.Checked)
                result += "성별 : 남자";
            else if (RdbF.Checked)
                result += "성별 : 여자";

            MessageBox.Show(result, "결과");
        }

        private void RdbM_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
