using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            string result = $"입사일 : {TxtDate.Text}\n";
            result += $"우편번호 : {TxtPost.Text}\n";
            result += $"주소 : {TxtAddr.Text.Trim()}\n";
            result += $"주민등록번호 : {TxtNumber.Text}\n";
            result += $"휴대폰번호 : {TxtPhone.Text}\n";
            result += $"이메일 : {TxtEmail.Text.Trim()}\n";

            MessageBox.Show(result, "개인정보",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
