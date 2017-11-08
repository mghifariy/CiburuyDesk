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
    public partial class TentangKami : Window
    {
        public TentangKami()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, MouseButtonEventArgs e)
        {
            isi.Visibility = Visibility.Hidden;
            dev.Visibility = Visibility.Visible;
            next.Visibility = Visibility.Hidden;
            back1.Visibility = Visibility.Visible;
        }

        private void back_Click(object sender, MouseButtonEventArgs e)
        {
            isi.Visibility = Visibility.Visible;
            dev.Visibility = Visibility.Hidden;
            next.Visibility = Visibility.Visible;
            back1.Visibility = Visibility.Hidden;
        }

        private void backp_Click(object sender, MouseButtonEventArgs e)
        {
            MenuUtama mu = new MenuUtama();
            mu.Show();
            this.Hide();
        }
    }
}
