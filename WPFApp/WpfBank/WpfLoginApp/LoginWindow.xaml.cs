using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace WpfLoginApp
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string connString = "Data Source=127.0.0.1;Initial Catalog=PMS;" +
                            "User ID=sa;Password=mssql_p@ssw0rd!";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            TxtUserId.Focus();
        }

        private void TxtUserId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                TxtPassword.Focus();
            }
        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                BtnLogin_Click(sender, e);
            }
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                if (conn.State == System.Data.ConnectionState.Closed)
                {
                    conn.Open();
                }

                try
                {
                    string query = $"SELECT count(*) " +
                               $"  FROM Member " +
                               $" WHERE UserId = '{TxtUserId.Text}' " +
                               $"   AND Password = '{TxtPassword.Password}'; ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    var result = Convert.ToInt32(cmd.ExecuteScalar()); // parameter가 object

                    if (result == 1)
                        MessageBox.Show("로그인 성공");
                    else
                        MessageBox.Show("로그인 실패");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"예외발생 : {ex.Message}");
                    return;
                }
            }    
        }
    }
}
