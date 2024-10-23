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
using MySqlConnector;
using System.Data;

namespace projectutstoko
{
    /// <summary>
    /// Interaction logic for Pelanggan.xaml
    /// </summary>
    public partial class Pelanggan : Page
    {


        public Pelanggan()
        {
            InitializeComponent();
            Loaddata();
            Koneksi.connection = new MySqlConnection(Koneksi.informasikeserver);

        }
        private void hilangkan()
        {
            txtNamaPelanggan.Clear();
            txtIdPelanggan.Clear();
            txtAlamat.Clear();
            txtEmail.Clear();
            txtNoTelp.Clear();
        }
        private void Loaddata()
        {
            using (Koneksi.connection = new MySqlConnection(Koneksi.informasikeserver))
            {
                try
                {
                    Koneksi.connection.Open();
                    string query = "SELECT * FROM pelanggan";
                    MySqlCommand cmd = new MySqlCommand(query, Koneksi.connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataGridPelanggan.ItemsSource = dt.DefaultView;
                    Koneksi.connection.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error saat memuat data: " + ex.Message);
                    Koneksi.connection.Close();
                }
            }
        }
        private void TambahPelanggan_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAlamat.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtNamaPelanggan.Text) || string.IsNullOrWhiteSpace(txtNoTelp.Text))
            {
                MessageBox.Show("Semua field harus diisi.");
                return;
            }

            using (var connection = new MySqlConnection(Koneksi.informasikeserver))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO pelanggan (nama_pelanggan, alamat_pelanggan, telp_pelanggan, email_pelanggan) " +
                                   "VALUES (@nama, @alamat, @telp, @email)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nama", txtNamaPelanggan.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@telp", txtNoTelp.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Pelanggan berhasil ditambahkan!");
                    hilangkan();
                    Loaddata();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat menambah pelanggan: " + ex.Message);
                }
            }
        }

        private void UpdatePelanggan_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPelanggan.Text))
            {
                MessageBox.Show("Pilih pelanggan dari tabel terlebih dahulu.");
                return;
            }

            using (var connection = new MySqlConnection(Koneksi.informasikeserver))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE pelanggan SET nama_pelanggan=@nama, alamat_pelanggan=@alamat, telp_pelanggan=@telp, email_pelanggan=@email " +
                                   "WHERE id_pelanggan=@id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nama", txtNamaPelanggan.Text);
                    cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
                    cmd.Parameters.AddWithValue("@telp", txtNoTelp.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@id", txtIdPelanggan.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Pelanggan berhasil diupdate!");
                        hilangkan();
                        Loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Pelanggan tidak ditemukan atau tidak ada yang diupdate.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat mengupdate pelanggan: " + ex.Message);
                }
            }
        }


        private void HapusPelanggan_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdPelanggan.Text))
            {
                MessageBox.Show("Pilih pelanggan dari tabel terlebih dahulu.");
                return;
            }

            using (var connection = new MySqlConnection(Koneksi.informasikeserver))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM pelanggan WHERE id_pelanggan=@id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", txtIdPelanggan.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Pelanggan berhasil dihapus!");
                        hilangkan();
                        Loaddata();
                    }
                    else
                    {
                        MessageBox.Show("Pelanggan tidak ditemukan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat menghapus pelanggan: " + ex.Message);
                }
            }
        }

        private void DataGridPelanggan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGridPelanggan.SelectedItem != null)
            {
                DataRowView row = (DataRowView)DataGridPelanggan.SelectedItem;
                txtIdPelanggan.Text = row["id_pelanggan"].ToString();
                txtNamaPelanggan.Text = row["nama_pelanggan"].ToString();
                txtAlamat.Text = row["alamat_pelanggan"].ToString();
                txtNoTelp.Text = row["telp_pelanggan"].ToString();
                txtEmail.Text = row["email_pelanggan"].ToString();

            }
        }
    } 
}
