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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            LblAutoSize.Text = LblMannulSize.Text = string.Empty; // label에 있는 텍스트 빈값으로 표시
        }

        private void BtnPushText_Click(object sender, EventArgs e)
        {
            string sample1 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Dolorum porro ullam magni amet incidunt eos numquam accusamus consequuntur reiciendis sapiente, corrupti iusto obcaecati unde ipsum, expedita illum dolor, quam velit.";
            string sample2 = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consequatur qui eum rem assumenda quia, ut repudiandae deleniti laborum nemo veniam optio quisquam earum aperiam esse soluta eligendi unde dolore impedit.";

            LblAutoSize.Text = sample1;
            LblMannulSize.Text = sample2;
        }
    }
}
