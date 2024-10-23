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
using System.Windows.Navigation;

namespace projectutstoko
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            


        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = new Admin();
        }

        private void PelangganButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = new Pelanggan();
        }

        private void ProdukButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = new Produk();
        }

        private void TransaksiButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = new Transaksi();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void TransaksiDetButton_Click(object sender, RoutedEventArgs e)
        {
            MainContentFrame.Content = new TransaksiDetail();
        }
    }
}
