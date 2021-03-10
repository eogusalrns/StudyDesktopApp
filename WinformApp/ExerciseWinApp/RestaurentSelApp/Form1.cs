using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurentSelApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            LblPlace.Text = $"이번 주 모임 장소는 : {cb.SelectedItem.ToString()}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new string[]
            {
                "히노아지","스시야마","퍼지네이블",
                "새마을식당","홍콩반점","롤링파스타"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
                comboBox1.Items.Add(comboBox1.Text);
            LblPlace.Text = $"{comboBox1.Text} 아이템 추가";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                LblPlace.Text = comboBox1.SelectedItem.ToString() + "Deleted!";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
                
        }
    }
}
