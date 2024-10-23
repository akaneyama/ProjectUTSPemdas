using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        public static string id_admin;
        public static string nama_admin;
       
        public LoginForm()
        {
            InitializeComponent();
            Koneksi.connection = new MySqlConnection(Koneksi.informasikeserver);
            
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {  
                if (string.IsNullOrEmpty(UsernameTextBox.Text) || string.IsNullOrEmpty(PasswordPasswordBox.Password))
                {
                MessageBox.Show("Username atau Password Tidak Boleh Kosong!");
                return;
                }
                string username = UsernameTextBox.Text;
                string password = Enkripsi.EncryptPassword(PasswordPasswordBox.Password);
                string masuk = "select count(*) from admin where username=@username and password=@password";
                using (MySqlCommand perintah = new MySqlCommand(masuk, Koneksi.connection))
                {
                    perintah.Parameters.AddWithValue("@username", username);
                    perintah.Parameters.AddWithValue("@password", password);
                    Koneksi.connection.Open();
                    int hasil = Convert.ToInt32(perintah.ExecuteScalar());
                    if (hasil == 1)
                    {
                        string ambilid = "select id_admin, nama_admin from admin where username=@username and password=@password";
                        using (MySqlCommand ambilidcommand = new MySqlCommand(ambilid, Koneksi.connection))
                        {
                            ambilidcommand.Parameters.AddWithValue("@username", username);
                            ambilidcommand.Parameters.AddWithValue("@password", password);
                            using (var bacadata = ambilidcommand.ExecuteReader())
                            {
                                while (bacadata.Read())
                                {
                                    id_admin = Convert.ToString(bacadata["id_admin"]);
                                    nama_admin = Convert.ToString(bacadata["nama_admin"]);
                                }
                                UsernameTextBox.Clear();
                                PasswordPasswordBox.Clear();
                                Koneksi.connection.Close();
                                Menu menu = new Menu();
                                menu.Show();
                                this.Hide();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Gagal");
                        Koneksi.connection.Close();
                        return;
                       
                    }
                    Koneksi.connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Koneksi Gagal! {ex.Message}");
                Koneksi.connection.Close();
            }

        }
    }
}
