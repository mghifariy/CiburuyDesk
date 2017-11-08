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
    /// Interaction logic for DataPengunjung.xaml
    /// </summary>
    public partial class DataPengunjung : Window
    {
        public DataPengunjung()
        {
            InitializeComponent();

            fillingDataGrid();

        }

        void fillingDataGrid()
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

        private void refreshbtn_Click(object sender, RoutedEventArgs e)
        {
            fillingDataGrid();
        }

        private void back_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Close();
        }
    }
}