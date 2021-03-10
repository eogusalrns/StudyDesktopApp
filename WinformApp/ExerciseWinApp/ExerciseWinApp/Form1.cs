using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciseWinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.AddRange(new String[]
            {
                "오스트리아,빈",
                "호주,멜버른",
                "일본,오사카",
                "호주,시드니",
                "캐나다,밴쿠버",
                "일본,도쿄",
                "캐나다,토론토",
                "덴마크,코펜하겐",
                "호주,애틀레이드",
                "대한민국,서울"
            });
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                listBox1.Items.Add(item);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(item);
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            List<string> lstRemove = new List<string>();

            foreach (string item in listBox1.SelectedItems)
            {
                lstRemove.Add(item);
            }
            foreach (string city in lstRemove)
            {
                listBox1.Items.Remove(city);
            }
        }

        private void BtnRemoveAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
