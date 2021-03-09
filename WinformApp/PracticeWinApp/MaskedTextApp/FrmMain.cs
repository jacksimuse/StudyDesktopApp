using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskedTextApp
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            // 입사일, 주민번호 유효한 값인지 체크필요

            string result = $"입사일 : {TxtHiredDate.Text}\n";
            result += $"우편번호 : {TxtZipcode.Text}\n";
            result += $"주소 : {TxtAddress.Text.Trim()}\n";
            result += $"휴대폰번호 : {TxtMobile.Text}\n";
            result += $"주민번호 : {TxtRegisterNumber.Text}\n";
            result += $"이메일 : {TxtEmail.Text.Trim()}\n";

            MessageBox.Show(result, "개인정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
