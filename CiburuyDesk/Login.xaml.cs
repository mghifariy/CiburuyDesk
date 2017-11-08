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
using System.Windows.Shapes;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CiburuyDesk
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        void login()
        {
            string pwd = pwdBox.Password;
            if (String.IsNullOrWhiteSpace(emailBox.Text) == true || String.IsNullOrWhiteSpace(pwd) == true)
            {
                MessageBox.Show("Email dan Password tidak boleh kosong", "Oops...", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=1234";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand("select email, pwd from db_ciburuy.t_akun where email = '" + this.emailBox.Text + "' and pwd = '" + pwd + "';", myConn);
                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;

                while (myReader.Read())
                {
                    count = count + 1;
                }

                if (count == 1)
                {
                    Admin adm = new Admin();
                    adm.Show();
                    this.Hide();
                    MessageBox.Show("Selamat datang, " + emailBox.Text, "Halo");
                }
                else
                {
                    MessageBox.Show("Email atau password yang dimasukkan salah", "Oops...", MessageBoxButton.OK, MessageBoxImage.Error);
                    myConn.Close();
                }

                myConn.Close();
            }
        }

        private void masukbtn_Click(object sender, MouseButtonEventArgs e)
        {
            login();
        }

        private void masukbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            masukBtn.Source = new BitmapImage(new Uri(@"img/masuk-btn-hover.png", UriKind.Relative));
        }

        private void masukbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            masukBtn.Source = new BitmapImage(new Uri(@"img/masuk-btn.png", UriKind.Relative));
        }
        /*
        private void pwdBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key != System.Windows.Input.Key.Enter) return;

            // your event handler here
            login();
        }
        */
        private void email_GotFocus(object sender, RoutedEventArgs e)
        {
            if (emailBox.Text == "Email")
            {
                emailBox.Text = "";
                emailBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void email_LostFocus(object sender, RoutedEventArgs e)
        {
            if (emailBox.Text == "")
            {
                emailBox.Text = "Email";
                emailBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
        }

        private void pass_GotFocus(object sender, RoutedEventArgs e)
        {
            passBox.Visibility = Visibility.Hidden;
            pwdBox.Focus();
        }

        private void pass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (pwdBox.Password == "")
            {
                passBox.Visibility = Visibility.Visible;
            }
        }
    }
}
