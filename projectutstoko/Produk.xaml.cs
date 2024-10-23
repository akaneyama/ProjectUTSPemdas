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
    /// Interaction logic for Produk.xaml
    /// </summary>
    public partial class Produk : Page
    {
        private string connectionString = "Server=daffaaditya.my.id;Database=tokodb;Uid=tugaskelompok;Pwd=tugaskelompok;";

        public Produk()
        {
            InitializeComponent();
            LoadData(); 
        }

        private void hilangkan()
        {
            txtIdProduk.Clear();
            txtNamaProduk.Clear();
            txtJumlahProduk.Clear();
            txtHargaProduk.Clear();
            txtDeskripsiProduk.Clear();
        }
        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM produk";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataGridProduk.ItemsSource = dt.DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat memuat data: " + ex.Message);
                }
            }
        }


        private void TambahProduk_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaProduk.Text) || string.IsNullOrWhiteSpace(txtJumlahProduk.Text) ||
                string.IsNullOrWhiteSpace(txtHargaProduk.Text) || string.IsNullOrWhiteSpace(txtDeskripsiProduk.Text))
            {
                MessageBox.Show("Semua field harus diisi.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO produk (nama_produk, jumlah_produk, harga_produk, deskripsi_produk) " +
                                   "VALUES (@nama, @jumlah, @harga, @deskripsi)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@nama", txtNamaProduk.Text);
                    cmd.Parameters.AddWithValue("@jumlah", txtJumlahProduk.Text);
                    cmd.Parameters.AddWithValue("@harga", txtHargaProduk.Text);
                    cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsiProduk.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produk berhasil ditambahkan!");
                    hilangkan();
                    conn.Close();
                    LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat menambah produk: " + ex.Message);
                }
            }
        }

        
        private void UpdateProduk_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProduk.Text))
            {
                MessageBox.Show("Pilih produk dari tabel terlebih dahulu.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE produk SET nama_produk=@nama, jumlah_produk=@jumlah, harga_produk=@harga, deskripsi_produk=@deskripsi " +
                                   "WHERE id_produk=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtIdProduk.Text);
                    cmd.Parameters.AddWithValue("@nama", txtNamaProduk.Text);
                    cmd.Parameters.AddWithValue("@jumlah", txtJumlahProduk.Text);
                    cmd.Parameters.AddWithValue("@harga", txtHargaProduk.Text);
                    cmd.Parameters.AddWithValue("@deskripsi", txtDeskripsiProduk.Text);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Produk berhasil diupdate!");
                        LoadData();
                        hilangkan();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Produk tidak ditemukan atau tidak ada yang diupdate.");
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat mengupdate produk: " + ex.Message);
                }
            }
        }

        
        private void HapusProduk_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdProduk.Text))
            {
                MessageBox.Show("Pilih produk dari tabel terlebih dahulu.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM produk WHERE id_produk=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtIdProduk.Text);
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Produk berhasil dihapus!");
                        LoadData();
                        hilangkan();
                        conn.Close();
                    }
                    else
                    {
                        MessageBox.Show("Produk tidak ditemukan.");
                        conn.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat menghapus produk: " + ex.Message);
                    conn.Close();
                }
            }
        }

        
        private void DataGridProduk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGridProduk.SelectedItem != null)
            {
                DataRowView row = (DataRowView)DataGridProduk.SelectedItem;
                txtIdProduk.Text = row["id_produk"].ToString();
                txtNamaProduk.Text = row["nama_produk"].ToString();
                txtJumlahProduk.Text = row["jumlah_produk"].ToString();
                txtHargaProduk.Text = row["harga_produk"].ToString();
                txtDeskripsiProduk.Text = row["deskripsi_produk"].ToString();

                
            }
        }
    }
}
