using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            Lsv.GridLines = true;
            Lsv.FullRowSelect = true;

            ListViewItem itemSwitch = new ListViewItem("닌텐도 스위치", 0);
            itemSwitch.SubItems.Add("600,000");
            itemSwitch.SubItems.Add("10");
            itemSwitch.SubItems.Add("6,000,000");

            ListViewItem itemDs = new ListViewItem("닌텐도 DS", 1);
            itemDs.SubItems.Add("300,000");
            itemDs.SubItems.Add("50");
            itemDs.SubItems.Add("15,000,000");

            ListViewItem itemPs = new ListViewItem("PlayStation 4", 2);
            itemPs.SubItems.Add("400,000");
            itemPs.SubItems.Add("10");
            itemPs.SubItems.Add("4,000,000");

            ListViewItem itemWill = new ListViewItem("닌텐도 윌", 3);
            itemWill.SubItems.Add("200,000");
            itemWill.SubItems.Add("30");
            itemWill.SubItems.Add("6,000,000");

            ListViewItem itemXbox = new ListViewItem("Xbox 360", 4);
            itemXbox.SubItems.Add("700,000");
            itemXbox.SubItems.Add("5");
            itemXbox.SubItems.Add("3,500,000");

            Lsv.Items.AddRange(new ListViewItem[] { itemSwitch, itemDs, itemPs, itemWill, itemXbox });

        }

        private void Lsv_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtSelected.Text = string.Empty;

            var selected = Lsv.SelectedItems;

            foreach (ListViewItem item in selected)
            {
                for (int i = 0; i < 4; i++)
                {
                    TxtSelected.Text += item.SubItems[i].Text + " ";
                }
            }
        }

        private void RdbDetail_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbDetail.Checked) Lsv.View = View.Details;
        }

        private void RdbList_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbList.Checked) Lsv.View = View.List;
        }

        private void RdbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSmall.Checked) Lsv.View = View.SmallIcon;
        }

        private void RdbBig_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbBig.Checked) Lsv.View = View.LargeIcon;
        }
    }
}
