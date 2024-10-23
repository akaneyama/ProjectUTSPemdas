using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace projectutstoko
{
    /// <summary>
    /// Interaction logic for TransaksiDetail.xaml
    /// </summary>
    public partial class TransaksiDetail : Page
    {
        public TransaksiDetail()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData(string filterAdmin = "", string filterProduk = "", int limit = 10)
        {
            using (var connection = new MySqlConnection(Koneksi.informasikeserver))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM transaksi_view1 WHERE 1=1";

                
                    if (!string.IsNullOrWhiteSpace(filterAdmin))
                    {
                        query += " AND nama_admin LIKE @namaAdmin";
                    }
                    if (!string.IsNullOrWhiteSpace(filterProduk))
                    {
                        query += " AND nama_produk LIKE @namaProduk";
                    }

                    query += " LIMIT @limit";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    if (!string.IsNullOrWhiteSpace(filterAdmin))
                    {
                        cmd.Parameters.AddWithValue("@namaAdmin", "%" + filterAdmin + "%");
                    }
                    if (!string.IsNullOrWhiteSpace(filterProduk))
                    {
                        cmd.Parameters.AddWithValue("@namaProduk", "%" + filterProduk + "%");
                    }
                    cmd.Parameters.AddWithValue("@limit", limit);

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataGridTransaksiView.ItemsSource = dt.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat memuat data transaksi: " + ex.Message);
                }
            }
        }

        private void TerapkanFilter_Click(object sender, RoutedEventArgs e)
        {
         
            string filterAdmin = txtFilterAdmin.Text;
            string filterProduk = txtFilterProduk.Text;
            int limit = 10;

          
            if (!string.IsNullOrWhiteSpace(txtFilterJumlah.Text) && int.TryParse(txtFilterJumlah.Text, out int inputLimit))
            {
                limit = inputLimit;
            }

      
            LoadData(filterAdmin, filterProduk, limit);
        }
    }
}
