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
using MySqlConnector;

namespace projectutstoko
{
    /// <summary>
    /// Interaction logic for pembayaran.xaml
    /// </summary>
    public partial class pembayaran : Window
    {
        
        public pembayaran()
        {
            InitializeComponent();
            
            txtTotalBelanja.Text = Convert.ToString(Transaksi.totalhargapembayaran);
           
            Koneksi.connection = new MySqlConnection(Koneksi.informasikeserver);
        }

        public static decimal kembalian = 0;
        private void TxtUangDibayarkan_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateKembalian();

        }

        private void UpdateKembalian()
        {

            if (decimal.TryParse(txtUangDibayarkan.Text, out decimal uangDibayarkan) &&
                decimal.TryParse(txtTotalBelanja.Text, out decimal totalBelanja))
            {
                kembalian = uangDibayarkan - totalBelanja;
                txtKembalian.Text = kembalian >= 0 ? kembalian.ToString() : "Uang tidak cukup!";
                BtnProsesPembayaran.IsEnabled = kembalian >= 0;
            }
            else
            {
                txtKembalian.Text = string.Empty;
                BtnProsesPembayaran.IsEnabled = false;
            }
        }

        private void BtnProsesPembayaran_Click(object sender, RoutedEventArgs e)
        {
          
                MessageBox.Show("Terima Kasih Telah Berbelanja");
                this.Hide();
            
           
        }

        private void BtnBatal_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string cariid = "SELECT MAX(id_transaksi) FROM transaksi";
                using (MySqlCommand ambilid = new MySqlCommand(cariid, Koneksi.connection))
                {
                    Koneksi.connection.Open();
                    int idyangdiambil = Convert.ToInt32(ambilid.ExecuteScalar());
                    if (idyangdiambil != null)
                    {
                        try
                        {
                            string hapusid = "delete from detail_transaksi where id_transaksi = @idyangdiambil; delete from transaksi where id_transaksi = @idyangdiambil";
                            using (MySqlCommand mulaihapusid = new MySqlCommand(hapusid, Koneksi.connection))
                            {
                                mulaihapusid.Parameters.AddWithValue("@idyangdiambil", idyangdiambil);
                                mulaihapusid.ExecuteNonQuery();
                                Koneksi.connection.Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"error: {ex.Message}");
                            Koneksi.connection.Close();
                        }
                    }
                    else
                    {
                        Koneksi.connection.Close();
                    }
                    Koneksi.connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"error {ex.Message}");
                return;
            }
            this.Close();
        }
    }
}
