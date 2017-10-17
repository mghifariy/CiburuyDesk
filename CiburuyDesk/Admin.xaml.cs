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

namespace CiburuyDesk
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void logout_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Anda yakin ingin keluar?", "Keluar", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if (result == MessageBoxResult.Yes)
            {
                BukuTamu bu = new BukuTamu();
                bu.Show();
                this.Hide();
            }
        }

        private void tile1_MouseEnter(object sender, MouseEventArgs e)
        {
            tile_1.Source = new BitmapImage(new Uri(@"img/db-icon-hover.png", UriKind.Relative));
        }

        private void tile1_MouseLeave(object sender, MouseEventArgs e)
        {
            tile_1.Source = new BitmapImage(new Uri(@"img/db-icon.png", UriKind.Relative));
        }

        private void tile1_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Masih dalam pengembangan", "Oops...", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void tile2_MouseEnter(object sender, MouseEventArgs e)
        {
            tile_2.Source = new BitmapImage(new Uri(@"img/dashboard-icon-hover.png", UriKind.Relative));
        }

        private void tile2_MouseLeave(object sender, MouseEventArgs e)
        {
            tile_2.Source = new BitmapImage(new Uri(@"img/dashboard-icon.png", UriKind.Relative));
        }

        private void tile2_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Masih dalam pengembangan", "Oops...", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void tile3_MouseEnter(object sender, MouseEventArgs e)
        {
            tile_3.Source = new BitmapImage(new Uri(@"img/log-icon-hover.png", UriKind.Relative));
        }

        private void tile3_MouseLeave(object sender, MouseEventArgs e)
        {
            tile_3.Source = new BitmapImage(new Uri(@"img/log-icon.png", UriKind.Relative));
        }

        private void tile3_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Masih dalam pengembangan", "Oops...", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
