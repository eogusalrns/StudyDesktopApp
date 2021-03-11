using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeCalcApp
{
    public partial class Form1 : Form
    {
        ComboBox[] Crds;
        ComboBox[] Grds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Txt1.Text = "인체의 구조와 기능";
            Txt2.Text = "일반수학 1";
            Txt3.Text = "디지털공학및실험";
            Txt4.Text = "자료구조";
            Txt5.Text = "비주얼프로그래밍";
            Txt6.Text = "기업가정신";
            Txt7.Text = "";

            ComboBox[] Crds = new ComboBox[] { Cmb1, Cmb2, Cmb3, Cmb4, Cmb5, Cmb6, Cmb7 };
            ComboBox[] Grds = new ComboBox[] { Grd1, Grd2, Grd3, Grd4, Grd5, Grd6, Grd7 };
            int[] arr = { 1, 2, 3, 4, 5 };
            List<string> lstGrade = new List<string>
            { "A+","A0","B+","B0","C+","C0","D+","D0","F"};

            foreach (var item in Crds)
            {
                foreach (var i in arr)
                {
                    item.Items.Add(i);
                }
            }

            foreach (var item in Grds)
            {
                foreach (var lst in lstGrade)
                {
                    item.Items.Add(lst);
                }
            }
        }

        private void BtnAvg_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalcredit = 0;
            
            for (int i = 0; i < Crds.Length; i++)
            {
                int crd = int.Parse(Crds[i].SelectedItem.ToString());
                totalcredit += crd;
                totalScore += crd * 
            }
        }
    }
}
