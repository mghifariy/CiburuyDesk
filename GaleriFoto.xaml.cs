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
    /// Interaction logic for GaleriFoto.xaml
    /// </summary>
    public partial class GaleriFoto : Window
    {
        public GaleriFoto()
        {
            InitializeComponent();
        }
        int i = 0;
        private void backp_Click(object sender, MouseButtonEventArgs e)
        {
            MenuUtama mu = new MenuUtama();
            mu.Show();
            this.Hide();
        }

        private void next_Click(object sender, MouseButtonEventArgs e)
        {
            if (i < 10)
            {
                i++;
                page.Text = i + " / 10";

            }
            else
            {
                page.Text = 10 + " / 10";
            }
        }

        private void back_Click(object sender, MouseButtonEventArgs e)
        {
            if (i > 1)
            {
                i--;
                page.Text = i + " / 10";

            }
            else
            {
                page.Text = 1 + " / 10";
            }
        }
    }
}
