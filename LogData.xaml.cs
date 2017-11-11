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
using System.Data;

namespace CiburuyDesk
{
    /// <summary>
    /// Interaction logic for LogData.xaml
    /// </summary>
    public partial class LogData : Window
    {
        public LogData()
        {
            InitializeComponent();
            //isiGridAll();
        }

        void isiGridAll()
        {
            string MyConString = "SERVER=localhost;DATABASE=db_ciburuy;UID=root;PASSWORD=1234;";
            string sql = "SELECT * FROM t_pengunjung ORDER BY id";
            MySqlConnection connection = new MySqlConnection(MyConString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            connection.Close();

            dataGrid.DataContext = dt;
        }

        void HitungAll()
        {
            string MyConString = "SERVER=localhost;DATABASE=db_ciburuy;UID=root;PASSWORD=1234;";
            string sql = "SELECT count(*) FROM t_pengunjung";
            MySqlConnection connection = new MySqlConnection(MyConString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            string nl = cmd.ExecuteScalar().ToString();
            connection.Close();

            labelNilai.Content = nl;
        }

        void hitung(string month)
        {
            string MyConString = "SERVER=localhost;DATABASE=db_ciburuy;UID=root;PASSWORD=1234;";
            string sql = "SELECT count(*) FROM t_pengunjung WHERE MONTH(tanggal) = '" + month + "'";
            MySqlConnection connection = new MySqlConnection(MyConString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            string nl = cmd.ExecuteScalar().ToString();
            connection.Close();

            labelNilai.Content = nl;
        }

        private void isiGrid(string month)
        {
            string MyConString = "SERVER=localhost;DATABASE=db_ciburuy;UID=root;PASSWORD=1234;";
            string sql = "SELECT * FROM t_pengunjung WHERE MONTH(tanggal) = '"+month+"'";
            MySqlConnection connection = new MySqlConnection(MyConString);
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(sql, connection);

            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());

            connection.Close();

            dataGrid.DataContext = dt;
        }
        
        private void refreshbtn_Click(object sender, RoutedEventArgs e)
        {
            if (comboBoxBulan.Text == "All")
            {
                isiGridAll();
                HitungAll();
            }
            else if (comboBoxBulan.Text == "Januari")
            {
                isiGrid("01");
                hitung("01");
            }
            else if (comboBoxBulan.Text == "Februari")
            {
                isiGrid("02");
                hitung("02");
            }
            else if (comboBoxBulan.Text == "Maret")
            {
                isiGrid("03");
                hitung("03");
            }
            else if (comboBoxBulan.Text == "April")
            {
                isiGrid("04");
                hitung("04");
            }
            else if (comboBoxBulan.Text == "Mei")
            {
                isiGrid("05");
                hitung("05");
            }
            else if (comboBoxBulan.Text == "Juni")
            {
                isiGrid("06");
                hitung("06");
            }
            else if (comboBoxBulan.Text == "Juli")
            {
                isiGrid("07");
                hitung("07");
            }
            else if (comboBoxBulan.Text == "Agustus")
            {
                isiGrid("08");
                hitung("08");
            }
            else if (comboBoxBulan.Text == "September")
            {
                isiGrid("09");
                hitung("09");
            }
            else if (comboBoxBulan.Text == "Oktober")
            {
                isiGrid("10");
                hitung("10");
            }
            else if (comboBoxBulan.Text == "November")
            {
                isiGrid("11");
                hitung("11");
            }
            else if (comboBoxBulan.Text == "Desember")
            {
                isiGrid("12");
                hitung("12");
            }
            else
            {
                MessageBox.Show("Oooopss... Input Salah");
            }
        }

        private void back_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
