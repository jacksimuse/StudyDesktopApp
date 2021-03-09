﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxWinApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnResult_Click(object sender, EventArgs e)
        {
            string checkState = string.Empty;

            List<CheckBox> boxes = new List<CheckBox> { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };

            foreach (var item in boxes)
            {
                checkState += $"{item.Text} : {item.Checked}\n";
            }

            MessageBox.Show(checkState, "체크상태");

            string summary = $"좋아하는 과일은 : ";

            foreach (var item in boxes)
            {
                if (item.Checked) // item.Checked == true
                    summary += item.Text + " ";
            }

            MessageBox.Show(summary, "좋아하는 과일 리스트");
        }
    }
}
