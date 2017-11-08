using System;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Documents;

namespace CiburuyDesk
{
    /// <summary>
    /// Interaction logic for Naskah.xaml
    /// </summary>
    public partial class InputGaleri : Window
    {
        public InputGaleri()
        {
            InitializeComponent();
        }

        string filename;
        private void button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Open File";
            openFile.Filter = "Image Files (*.jpg)|*.jpg";
            Nullable<bool> result = openFile.ShowDialog();
            if (result == true)
            {
                filename = openFile.FileName;
                filenameTextBox.Text = filename;
                tile_1_Copy.Source = new BitmapImage(new Uri(@filename));
            }

        }

        MySqlCommand cmd;
        private void insertImage()
        {
            string host = "localhost";
            string user = "root";
            string password = "1234";
            string database = "db_ciburuy";
            string connStr = "server=" + host + ";user=" + user + ";database=" + database + ";password=" + password + ";";
            string fileLocation = filename;
            MySqlConnection conn = new MySqlConnection(connStr);
            byte[] image = null;
            FileStream stream = new FileStream(fileLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            image = brs.ReadBytes((int)stream.Length);
            string richText = new TextRange(keteranganRichTextBox.Document.ContentStart, keteranganRichTextBox.Document.ContentEnd).Text;

            conn.Open();

            string sqlQuery = "Insert into t_galeri(id, image, judul, keterangan) values ('" + IDtextBox.Text + "', @image, '" + judulTextBox.Text + "', '" + richText + "')";

            cmd = new MySqlCommand(sqlQuery, conn);
            cmd.Parameters.Add(new MySqlParameter("@image", image));
            int N = cmd.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show(N.ToString() + " Data Tersimpan");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            insertImage();
        }

        private void backp_Click(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Admin ad = new Admin();
            ad.Show();
            this.Hide();
        }
    }
}
