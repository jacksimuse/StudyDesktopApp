using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfPracticeApp.Businesslogic;

namespace WpfPracticeApp
{
    /// <summary>
    /// Discussion.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Discussion : Page
    {
        public Discussion()
        {
            InitializeComponent();
        }

        private void Page_Initialized(object sender, EventArgs e)
        {
            // runtime 데이터 바인딩 하는 동적 바인딩
            Talk talk = new Talk();
            this.DataContext = talk;
        }
    }
}
