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
    /// Interaction logic for TentangKami.xaml
    /// </summary>
    public partial class MenuUtama : Window
    {
        public MenuUtama()
        {
            InitializeComponent();
        }

        private void tile1_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Masih dalam pengembangan", "Oops...", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void tile2_Click(object sender, MouseButtonEventArgs e)
        {
            GaleriFoto gf = new GaleriFoto();
            gf.Show();
            this.Hide();
        }

        private void tile3_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Masih dalam pengembangan", "Oops...", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void tile4_Click(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("Masih dalam pengembangan", "Oops...", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void tile5_Click(object sender, MouseButtonEventArgs e)
        {
            TentangKami tk = new TentangKami();
            tk.Show();
            this.Hide();
        }

        private void tile1_MouseEnter(object sender, MouseEventArgs e)
        {
            tile_1.Source = new BitmapImage(new Uri(@"img/tile-1-hover.png", UriKind.Relative));
        }

        private void tile1_MouseLeave(object sender, MouseEventArgs e)
        {
            tile_1.Source = new BitmapImage(new Uri(@"img/tile-1.png", UriKind.Relative));
        }

        private void tile2_MouseEnter(object sender, MouseEventArgs e)
        {
            tile_2.Source = new BitmapImage(new Uri(@"img/tile-2-hover.png", UriKind.Relative));
        }

        private void tile2_MouseLeave(object sender, MouseEventArgs e)
        {
            tile_2.Source = new BitmapImage(new Uri(@"img/tile-2.png", UriKind.Relative));
        }

        private void tile3_MouseEnter(object sender, MouseEventArgs e)
        {
            tile_3.Source = new BitmapImage(new Uri(@"img/tile-3-hover.png", UriKind.Relative));
        }

        private void tile3_MouseLeave(object sender, MouseEventArgs e)
        {
            tile_3.Source = new BitmapImage(new Uri(@"img/tile-3.png", UriKind.Relative));
        }

        private void tile4_MouseEnter(object sender, MouseEventArgs e)
        {
            tile_4.Source = new BitmapImage(new Uri(@"img/tile-4-hover.png", UriKind.Relative));
        }

        private void tile4_MouseLeave(object sender, MouseEventArgs e)
        {
            tile_4.Source = new BitmapImage(new Uri(@"img/tile-4.png", UriKind.Relative));
        }

        private void tile5_MouseEnter(object sender, MouseEventArgs e)
        {
            tile_5.Source = new BitmapImage(new Uri(@"img/tile-5-hover.png", UriKind.Relative));
        }

        private void tile5_MouseLeave(object sender, MouseEventArgs e)
        {
            tile_5.Source = new BitmapImage(new Uri(@"img/tile-5.png", UriKind.Relative));
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

        private void src_Click(object sender, MouseButtonEventArgs e)
        {
            PencarianLontar pl = new PencarianLontar();
            pl.Show();
            this.Hide();
        }
    }
}