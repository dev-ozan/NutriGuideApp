using Microsoft.Data.SqlClient;
using NutriGuide.Entity.Data;
using NutriGuide.Entity.Enums;
using System.Text;

namespace NutriGuide.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            if (lblSignUp.Text == "Sign Up!")
            {

                string text = "SIGN UP";
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    Thread.Sleep(50);
                    sb.Append(text[i]);
                    btnLogin.Text = sb.ToString();
                    Refresh();
                }
                lblYazi.Text = "Already have an account?";
                lblSignUp.Text = "Login";
            }
            else if (lblSignUp.Text == "Login")
            {
                btnLogin.Text = "";
                string text = "LOGIN";
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < text.Length; i++)
                {
                    Thread.Sleep(50);
                    sb.Append(text[i]);
                    btnLogin.Text = sb.ToString();
                    Refresh();
                }
                lblYazi.Text = "Don't have an account?";
                lblSignUp.Text = "Sign Up!";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Text = "";
            string text = "LOGIN";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(50);
                sb.Append(text[i]);
                btnLogin.Text = sb.ToString();
                Refresh();
            }
            
            if (btnLogin.Text == "LOGIN" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                string connectionString = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanýcý verilerini ekleme
                    Kullanici kullanici = new Kullanici
                    {
                        KullaniciAdi = "john_doe",
                        KullaniciPassword = "123456",
                        Ad = "John",
                        Soyad = "Doe",
                        Cinsiyet = "Erkek",
                        DogumTarihi = new DateTime(1990, 1, 1),
                        DietBaslamaTarihi = DateTime.Now,
                        DietBitisTarihi = DateTime.Now.AddDays(30),
                        Kilosu = 75,
                        Boyu = 180,
                        HedefKilosu = 70,
                        KullaniciTipi = KullaniciTipi.Kullanici,
                        Diyetler = "Gluten-free, Vegan"
                    };

                    string insertQuery = "INSERT INTO Kullanici (KullaniciAdi, KullaniciPassword, Ad, Soyad, Cinsiyet, DogumTarihi, DietBaslamaTarihi, DietBitisTarihi, Kilosu, Boyu, HedefKilosu, KullaniciTipi, Diyetler) " +
                        "VALUES (@KullaniciAdi, @KullaniciPassword, @Ad, @Soyad, @Cinsiyet, @DogumTarihi, @DietBaslamaTarihi, @DietBitisTarihi, @Kilosu, @Boyu, @HedefKilosu, @KullaniciTipi, @Diyetler);";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        // Parametreleri ekleme
                        command.Parameters.AddWithValue("@KullaniciAdi", kullanici.KullaniciAdi);
                        command.Parameters.AddWithValue("@KullaniciPassword", kullanici.KullaniciPassword);
                        command.Parameters.AddWithValue("@Ad", kullanici.Ad);
                        command.Parameters.AddWithValue("@Soyad", kullanici.Soyad);
                        command.Parameters.AddWithValue("@Cinsiyet", kullanici.Cinsiyet);
                        command.Parameters.AddWithValue("@DogumTarihi", kullanici.DogumTarihi);
                        command.Parameters.AddWithValue("@DietBaslamaTarihi", kullanici.DietBaslamaTarihi);
                        command.Parameters.AddWithValue("@DietBitisTarihi", kullanici.DietBitisTarihi);
                        command.Parameters.AddWithValue("@Kilosu", kullanici.Kilosu);
                        command.Parameters.AddWithValue("@Boyu", kullanici.Boyu);
                        command.Parameters.AddWithValue("@HedefKilosu", kullanici.HedefKilosu);
                        command.Parameters.AddWithValue("@KullaniciTipi", kullanici.KullaniciTipi.ToString());
                        command.Parameters.AddWithValue("@Diyetler", kullanici.Diyetler);

                        // Sorguyu çalýþtýrma
                        command.ExecuteNonQuery();
                    }

                    Console.WriteLine("Kullanýcý verisi baþarýyla eklendi.");

                    connection.Close();
                }


                MainMenu mainMenu = new MainMenu(txtPassword.Text, txtUsername.Text);
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}