using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateCalcApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DtpDirthDay_ValueChanged(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime birthday = DtpDirthDay.Value;

            TxtResult.Text = $"{today.Subtract(birthday).TotalDays : #,###}"; // 오늘에서 자기 생일을 뺀것을 총 일수로 표현
            TxtYear.Text = (today.Subtract(birthday).TotalDays / 365).ToString("0"); // 365로 나눠서 만으로 표시
        }
    }
}
