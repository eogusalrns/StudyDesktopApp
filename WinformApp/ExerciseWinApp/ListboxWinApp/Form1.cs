using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListboxWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            TxtCountryIndex.Text = lst.SelectedIndex.ToString();
            TxtCountryItem.Text = lst.SelectedItem.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            TxtCityIndex.Text = lst.SelectedIndex.ToString();
            TxtCityItem.Text = lst.SelectedItem.ToString();
        }

        private void LsbGDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox;
            TxtGDPIndex.Text = lst.SelectedIndex.ToString();
            TxtGDPItem.Text = lst.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LsbCity.Items.AddRange(new string[]
            {
                "오스트리아,빈",
                "호주,애들레이드",
                "대한민국,서울"
            });

            List<string> lstGDP = new List<string>
            {
                "미국","러시아","중국","영국","독일","이스라엘","UAE"
            };
            LsbCountry.DataSource = lstGDP;
        }
    }
}
