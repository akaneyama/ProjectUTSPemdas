using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Transaksi.xaml
    /// </summary>
    
    public partial class Transaksi : Page
    {
        private decimal totalHarga = 0;

        private ObservableCollection<Pelanggan> PelangganList = new ObservableCollection<Pelanggan>();
        private ObservableCollection<Produk> produkList = new ObservableCollection<Produk>();
        public static decimal totalhargapembayaran;
        public class DetailTransaksi
        {
            public string Produk { get; set; }
            public int Jumlah { get; set; }
            public decimal HargaSatuan { get; set; }
            public decimal Subtotal { get; set; }
            public int ProdukId { get; set; }
        }

        public class Pelanggan
        {
            public int IdPelanggan { get; set; }
            public string NamaPelanggan { get; set; }
        }

        public class Produk
        {
            public int IdProduk { get; set; }
            public string NamaProduk { get; set; }
            public decimal HargaProduk { get; set; }
            public int JumlahProduk { get; set; }
        }
        private ObservableCollection<DetailTransaksi> detailTransaksis = new ObservableCollection<DetailTransaksi>();
        private int idAdmin = Convert.ToInt32(LoginForm.id_admin);

        public Transaksi()
        {
            InitializeComponent();
            LoadData();
            dataGridTransaksi.ItemsSource = detailTransaksis;
        }
        private void RefreshCmbPelanggan()
        {
            cmbPelanggan.ItemsSource = null;
            cmbPelanggan.ItemsSource = PelangganList;
        }
        private void DataGridProduk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
    
            if (dataGridProduk.SelectedItem is Produk selectedProduk)
            {
                cmbProduk.SelectedItem = selectedProduk;
                txtHargaSatuan.Text = selectedProduk.HargaProduk.ToString();
            }
        }
        private void DataGridPelanggan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGridPelanggan.SelectedItem is Pelanggan selectedPelanggan)
            {
              
                cmbPelanggan.ItemsSource = new List<Pelanggan> { selectedPelanggan };
                cmbPelanggan.SelectedItem = selectedPelanggan; 
            }
        }


        private void LoadData()
        {
            cmbPelanggan.ItemsSource = GetPelanggan();
            PelangganList = GetPelanggan();
            produkList = GetProduk(); 
            cmbProduk.ItemsSource = produkList; 
            dataGridProduk.ItemsSource = produkList;
            dataGridPelanggan.ItemsSource = PelangganList;
        }
       
        private void BtnRefresh_Click(object sender, RoutedEventArgs e)
        {
            produkList = GetProduk(); 

            
            dataGridProduk.ItemsSource = produkList;
            cmbProduk.ItemsSource = produkList;
            txtCariProduk.Text = "";
        }
        private void TxtCariPelanggan_KeyUp(object sender, KeyEventArgs e)
        {

            string keywordp = txtCariPelanggan.Text.ToLower();
            var filteredPelanggan = PelangganList.Where(x => x.NamaPelanggan.ToLower().Contains(keywordp)).ToList();
            dataGridPelanggan.ItemsSource = filteredPelanggan;
        }

        private void TxtCariProduk_KeyUp(object sender, KeyEventArgs e)
        {
 
            string keyword = txtCariProduk.Text.ToLower();
            var filteredProduk = produkList.Where(p => p.NamaProduk.ToLower().Contains(keyword)).ToList();
            dataGridProduk.ItemsSource = filteredProduk;
        }

        private ObservableCollection<Pelanggan> GetPelanggan()
        {
            var pelangganList = new ObservableCollection<Pelanggan>();
            try
            {
               Koneksi.connection.Open();
                string query = "SELECT id_pelanggan, nama_pelanggan FROM pelanggan";
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    pelangganList.Add(new Pelanggan
                    {
                        IdPelanggan = reader.GetInt32(0),
                        NamaPelanggan = reader.GetString(1)
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Koneksi.connection.Close();
            }

            return pelangganList;
        }

        private ObservableCollection<Produk> GetProduk()
        {
            var produkList = new ObservableCollection<Produk>();
            try
            {
                Koneksi.connection.Open();
                string query = "SELECT id_produk, nama_produk, harga_produk, jumlah_produk FROM produk"; 
                MySqlCommand cmd = new MySqlCommand(query, Koneksi.connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    produkList.Add(new Produk
                    {
                        IdProduk = reader.GetInt32(0),
                        NamaProduk = reader.GetString(1),
                        HargaProduk = reader.GetDecimal(2),
                        JumlahProduk = reader.GetInt32(3) 
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Koneksi.connection.Close();
            }

            return produkList;
        }


        private void CmbPelanggan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedPelanggan = cmbPelanggan.SelectedItem as Pelanggan;
           
        }

        private void CmbProduk_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduk = cmbProduk.SelectedItem as Produk;
            if (selectedProduk != null)
            {
                txtHargaSatuan.Text = selectedProduk.HargaProduk.ToString();

                
                if (selectedProduk.JumlahProduk <= 0)
                {
                    MessageBox.Show("Produk habis. Tidak bisa menambah produk ini ke transaksi.", "Stok Habis", MessageBoxButton.OK, MessageBoxImage.Warning);
                    BtnTambah.IsEnabled = false; 
                }
                else
                {
                    BtnTambah.IsEnabled = true;
                }
            }
        }
        private void BtnHapusProduk_Click(object sender, RoutedEventArgs e)
        {
            var selectedDetail = (DetailTransaksi)dataGridTransaksi.SelectedItem;
            if (selectedDetail != null)
            {
                
                var produkDiTransaksi = GetProdukById(selectedDetail.ProdukId);
                if (produkDiTransaksi != null)
                {
                    produkDiTransaksi.JumlahProduk += selectedDetail.Jumlah;
                    dataGridProduk.Items.Refresh(); 
                }

            
                totalHarga -= selectedDetail.Subtotal;
                txtTotalHarga.Text = totalHarga.ToString("C"); 
                detailTransaksis.Remove(selectedDetail);
            }
            else
            {
                MessageBox.Show("Pilih produk yang ingin dihapus dari transaksi.");
            }
        }

        
        private Produk GetProdukById(int idProduk)
        {
            return (from p in (ObservableCollection<Produk>)cmbProduk.ItemsSource
                    where p.IdProduk == idProduk select p).FirstOrDefault();
        }

        private void BtnTambah_Click(object sender, RoutedEventArgs e)
        {
            var selectedProduk = cmbProduk.SelectedItem as Produk;
            if (selectedProduk != null && int.TryParse(txtJumlah.Text, out int jumlah) && jumlah > 0)
            {
                if (jumlah > selectedProduk.JumlahProduk)
                {
                    MessageBox.Show("Jumlah yang diminta melebihi stok yang tersedia.", "Stok Tidak Cukup", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                selectedProduk.JumlahProduk -= jumlah;
                dataGridProduk.Items.Refresh(); 
                var subtotal = selectedProduk.HargaProduk * jumlah;
                detailTransaksis.Add(new DetailTransaksi
                {
                    Produk = selectedProduk.NamaProduk,
                    Jumlah = jumlah,
                    HargaSatuan = selectedProduk.HargaProduk,
                    Subtotal = subtotal,
                    ProdukId = selectedProduk.IdProduk
                });

                totalHarga += subtotal;
                txtTotalHarga.Text = totalHarga.ToString("C"); 

                cmbProduk.SelectedItem = null;
                txtJumlah.Text = string.Empty;
                txtHargaSatuan.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Pilih produk dan masukkan jumlah yang valid.");
            }
        }

        private void BtnSimpan_Click(object sender, RoutedEventArgs e)
        {
            if (detailTransaksis.Count == 0)
            {
                MessageBox.Show("Tidak ada detail transaksi untuk disimpan.");
                return;
            }

            SaveTransaksi();
            totalhargapembayaran = totalHarga;
            MessageBox.Show("Transaksi berhasil disimpan.");

            detailTransaksis.Clear();
           
            totalHarga = 0;
            txtTotalHarga.Text = totalHarga.ToString("C");
            LoadData();
            pembayaran Bayar = new pembayaran();
            Bayar.ShowDialog();
        }

        public void SaveTransaksi()
        {
            try
            {
                Koneksi.connection.Open();
                string transaksiQuery = "INSERT INTO transaksi (id_admin, id_pelanggan, tanggal_transaksi, total_harga) VALUES (@IdAdmin, @IdPelanggan, @Tanggal, @TotalHarga)";
                using (var transaksiCmd = new MySqlCommand(transaksiQuery, Koneksi.connection))
                {
                    transaksiCmd.Parameters.AddWithValue("@IdAdmin", idAdmin);
                    transaksiCmd.Parameters.AddWithValue("@IdPelanggan", (cmbPelanggan.SelectedItem as Pelanggan)?.IdPelanggan);
                    transaksiCmd.Parameters.AddWithValue("@Tanggal", DateTime.Now);
                    transaksiCmd.Parameters.AddWithValue("@TotalHarga", detailTransaksis.Sum(d => d.Subtotal));
                    transaksiCmd.ExecuteNonQuery();
                }

                long idTransaksi;
                using (var idCmd = new MySqlCommand("SELECT LAST_INSERT_ID()", Koneksi.connection))
                {
                    idTransaksi = Convert.ToInt64(idCmd.ExecuteScalar());
                }
                foreach (var detail in detailTransaksis)
                {
                    string detailQuery = "INSERT INTO detail_transaksi (id_admin, id_transaksi, id_produk, jumlah_produk, harga_satuan, subtotal) VALUES (@IdAdmin, @IdTransaksi, @IdProduk, @JumlahProduk, @HargaSatuan, @Subtotal)";
                    using (var detailCmd = new MySqlCommand(detailQuery, Koneksi.connection))
                    {
                        detailCmd.Parameters.AddWithValue("@IdAdmin", idAdmin);
                        detailCmd.Parameters.AddWithValue("@IdTransaksi", idTransaksi);
                        detailCmd.Parameters.AddWithValue("@IdProduk", detail.ProdukId);
                        detailCmd.Parameters.AddWithValue("@JumlahProduk", detail.Jumlah);
                        detailCmd.Parameters.AddWithValue("@HargaSatuan", detail.HargaSatuan);
                        detailCmd.Parameters.AddWithValue("@Subtotal", detail.Subtotal);
                        detailCmd.ExecuteNonQuery();
                    }
                    UpdateStok(detail.ProdukId, detail.Jumlah);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat menyimpan transaksi: " + ex.Message);
            }
            finally
            {
                Koneksi.connection.Close();
            }
        }

        private void UpdateStok(int produkId, int jumlahTerjual)
        {
            try
            {
                string updateQuery = "UPDATE produk SET jumlah_produk = jumlah_produk - @JumlahTerjual WHERE id_produk = @IdProduk";
                using (var updateCmd = new MySqlCommand(updateQuery, Koneksi.connection))
                {
                    updateCmd.Parameters.AddWithValue("@JumlahTerjual", jumlahTerjual);
                    updateCmd.Parameters.AddWithValue("@IdProduk", produkId);
                    updateCmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat mengupdate stok: " + ex.Message);
            }
        }
    }

    
}
