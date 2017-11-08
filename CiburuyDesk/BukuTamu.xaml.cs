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
    /// Interaction logic for BukuTamu.xaml
    /// </summary>
    public partial class BukuTamu : Window
    {
        public BukuTamu()
        {
            InitializeComponent();
            
        }

      
        private void masukbtn_Click(object sender, MouseButtonEventArgs e)
        {
            if (namaBox.Text == "Nama")
            {
                namaBox.Text = "";
            }
            if (emailBox.Text == "Email (opsional)")
            {
                emailBox.Text = "";
            }
            if (String.IsNullOrWhiteSpace(namaBox.Text) == true)
            {

                MessageBoxResult result = MessageBox.Show("Nama tidak boleh kosong", "Oops...", MessageBoxButton.OK, MessageBoxImage.Warning);
                if (result == MessageBoxResult.OK)
                {
                    namaBox.Text = "Nama";
                    namaBox.Foreground = new SolidColorBrush(Colors.LightGray);
                    emailBox.Text = "Email (opsional)";
                    emailBox.Foreground = new SolidColorBrush(Colors.LightGray);
                }
            }
            else
            {
                string host = "localhost";
                string user = "root";
                string password = "1234";
                string database = "db_ciburuy";
                string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";";
                string query = "insert into t_pengunjung(nama,email)values('" + this.namaBox.Text + "','" + this.emailBox.Text + "');";
                MySqlConnection conn = new MySqlConnection(connStr);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader read;
                conn.Open();
                read = cmd.ExecuteReader();
                conn.Close();
                MenuUtama mu = new MenuUtama();
                mu.Show();
                this.Hide();
                MessageBox.Show("Selamat datang, " + namaBox.Text, "Halo");
            }
        }

        private void masukbtn_MouseEnter(object sender, MouseEventArgs e)
        {
            masukBtn.Source = new BitmapImage(new Uri(@"img/masuk-btn-hover.png", UriKind.Relative));
        }

        private void masukbtn_MouseLeave(object sender, MouseEventArgs e)
        {
            masukBtn.Source = new BitmapImage(new Uri(@"img/masuk-btn.png", UriKind.Relative));
        }

        private void text_Click(object sender, MouseButtonEventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void namaBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (namaBox.Text == "Nama")
            { 
                namaBox.Text = "";
                namaBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void namaBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (namaBox.Text == "")
            {
                namaBox.Text = "Nama";
                namaBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
        }

        private void emailBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (emailBox.Text == "Email (opsional)")
            {
                emailBox.Text = "";
                emailBox.Foreground = new SolidColorBrush(Colors.Black);
            }
        }

        private void emailBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (emailBox.Text == "")
            {
                emailBox.Text = "Email (opsional)";
                emailBox.Foreground = new SolidColorBrush(Colors.LightGray);
            }
        }
    }
}