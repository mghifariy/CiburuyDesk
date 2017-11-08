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
    /// Interaction logic for PencarianLontar.xaml
    /// </summary>
    public partial class PencarianLontar : Window
    {
        public PencarianLontar()
        {
            InitializeComponent();
        }

        private void backp_Click(object sender, MouseButtonEventArgs e)
        {
            MenuUtama mu = new MenuUtama();
            mu.Show();
            this.Hide();
        }
    }
}
