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
            ListViewItem itemSwitch = new ListViewItem("Nintendo Switch", 0);
            itemSwitch.SubItems.Add("600,000");
            itemSwitch.SubItems.Add("10");
            itemSwitch.SubItems.Add("6,000,000");

            ListViewItem itemDs = new ListViewItem("Nintendo DS", 1);
            itemSwitch.SubItems.Add("300,000");
            itemSwitch.SubItems.Add("50");
            itemSwitch.SubItems.Add("1,500,000");

            ListViewItem itemPs = new ListViewItem("PlayStation 4", 2);
            itemSwitch.SubItems.Add("400,000");
            itemSwitch.SubItems.Add("10");
            itemSwitch.SubItems.Add("4,000,000");

            ListViewItem itemWii = new ListViewItem("Nintendo Wii", 3);
            itemSwitch.SubItems.Add("200,000");
            itemSwitch.SubItems.Add("30");
            itemSwitch.SubItems.Add("6,000,000");

            ListViewItem itemXbox = new ListViewItem("XBox 360", 4);
            itemSwitch.SubItems.Add("700,000");
            itemSwitch.SubItems.Add("10");
            itemSwitch.SubItems.Add("");

            LsbProduct.Items.AddRange(new ListViewItem[] { itemSwitch, itemDs, itemPs, itemWii, itemXbox });

        }

        private void RdbDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbDetails.Checked) LsbProduct.View = View.Details;
        }

        private void RdbList_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbList.Checked) LsbProduct.View = View.List;
        }

        private void RdbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbSmallIcon.Checked) LsbProduct.View = View.SmallIcon;
        }

        private void RdbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (RdbLargeIcon.Checked) LsbProduct.View = View.LargeIcon;
        }

        private void LsbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
