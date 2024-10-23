using System;
using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySqlConnector;

namespace projectutstoko
{
    /// <summary>
    /// Interaction logic for Admin.xaml
    /// </summary>
    public partial class Admin : Page
    {
        public Admin()
        {
            InitializeComponent();
            Loaddata(); 
        }

        private void hilangkan()
        {
            txtNamaAdmin.Clear();
            txtIdAdmin.Clear();
            txtTelpAdmin.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void Loaddata()
        {
            using (var connection = new MySqlConnection(Koneksi.informasikeserver))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM admin";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    DataGridAdmin.ItemsSource = dt.DefaultView;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat memuat data: " + ex.Message);
                }
            }
        }

        private void TambahAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNamaAdmin.Text) || string.IsNullOrWhiteSpace(txtTelpAdmin.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                MessageBox.Show("Semua field harus diisi.");
                return;
            }

            using (var connection = new MySqlConnection(Koneksi.informasikeserver))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO admin (nama_admin, telp_admin, username, password) " +
                                   "VALUES (@nama, @telp, @username, @password)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nama", txtNamaAdmin.Text);
                    cmd.Parameters.AddWithValue("@telp", txtTelpAdmin.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", Enkripsi.EncryptPassword(txtPassword.Password));  
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Admin berhasil ditambahkan!");
                    hilangkan();  
                    Loaddata();   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat menambah admin: " + ex.Message);
                }
            }
        }

        private void UpdateAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdAdmin.Text))
            {
                MessageBox.Show("Pilih admin dari tabel terlebih dahulu.");
                return;
            }

            using (var connection = new MySqlConnection(Koneksi.informasikeserver))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE admin SET nama_admin=@nama, telp_admin=@telp, username=@username, password=@password " +
                                   "WHERE id_admin=@id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@nama", txtNamaAdmin.Text);
                    cmd.Parameters.AddWithValue("@telp", txtTelpAdmin.Text);
                    cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", Enkripsi.EncryptPassword(txtPassword.Password));
                    cmd.Parameters.AddWithValue("@id", txtIdAdmin.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Admin berhasil diupdate!");
                        hilangkan();  
                        Loaddata();   
                    }
                    else
                    {
                        MessageBox.Show("Admin tidak ditemukan atau tidak ada yang diupdate.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat mengupdate admin: " + ex.Message);
                }
            }
        }

        private void HapusAdmin_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdAdmin.Text))
            {
                MessageBox.Show("Pilih admin dari tabel terlebih dahulu.");
                return;
            }

            using (var connection = new MySqlConnection(Koneksi.informasikeserver))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM admin WHERE id_admin=@id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@id", txtIdAdmin.Text);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Admin berhasil dihapus!");
                        hilangkan();  
                        Loaddata();   
                    }
                    else
                    {
                        MessageBox.Show("Admin tidak ditemukan.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saat menghapus admin: " + ex.Message);
                }
            }
        }

        private void DataGridAdmin_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (DataGridAdmin.SelectedItem is DataRowView row)
            {
                txtIdAdmin.Text = row["id_admin"].ToString();
                txtNamaAdmin.Text = row["nama_admin"].ToString();
                txtTelpAdmin.Text = row["telp_admin"].ToString();
                txtUsername.Text = row["username"].ToString();
                txtPassword.Password = row["password"].ToString();
            }
        }
    }
}
