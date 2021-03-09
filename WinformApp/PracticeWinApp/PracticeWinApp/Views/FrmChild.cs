using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWinApp.Views
{
    public partial class FrmChild : Form
    {
        public FrmChild()
        {
            InitializeComponent();
        }

        private void FrmChild_Load(object sender, EventArgs e)
        {
            this.ClientSize = new Size(300, 150);
            this.Text = "자식";

            this.CenterToParent();
            
        }

        private void BtnQuestion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("정답입니까?", "질문", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                MessageBox.Show("정답이랍니다!");
            }
            else
            {
                MessageBox.Show("틀렸다네요");
            }

            
        }
    }
}
