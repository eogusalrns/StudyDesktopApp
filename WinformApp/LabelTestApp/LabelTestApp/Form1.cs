using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelTestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblAutoSize.Text = LblManualSize.Text = "";
        }

        private void BtnPushText_Click(object sender, EventArgs e)
        {
            string sample1 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Voluptatum, cum! Natus quia mollitia nesciunt? Perferendis tenetur expedita aliquam rerum, facilis quos natus similique voluptatibus. Pariatur, expedita. Cum architecto non fuga!";
            string sample2 = "Lorem ipsum dolor sit amet consectetur, adipisicing elit. Atque pariatur expedita veritatis tenetur nisi totam impedit consequatur, dicta deserunt vero, enim iure sed tempore quaerat! Error voluptatem necessitatibus voluptate incidunt!";

            LblAutoSize.Text = sample1;
            LblManualSize.Text = sample2;
        }
    }
}
