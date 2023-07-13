using Microsoft.Data.SqlClient;
using NutriGuide.DataAccessLayer.Concrets;
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
            using (NutriGuideContext _Db = new NutriGuideContext())
            {
                string Pwd = txtPassword.Text;
                string hashedPwd = PasswordHasher.HashPassword(Pwd);
                var kisi = _Db.Kullanicilar.FirstOrDefault(x => x.KullaniciAdi == txtUsername.Text);
                if (btnLogin.Text == "LOGIN"  && _Db.Kullanicilar.Contains(kisi) && kisi.KullaniciPassword == hashedPwd && txtUsername.Text == kisi.KullaniciAdi)
                {
                    MessageBox.Show("Giriþ Baþarýlý");
                    


                    MainMenu mainMenu = new MainMenu(txtUsername.Text);
                    mainMenu.Show();
                    this.Hide();
                }
                else if (lblSignUp.Text == "Login")
                {
                    MessageBox.Show("Baþarýyla Üye oldunuz.");
                    using (NutriGuideContext _db = new NutriGuideContext())
                    {
                        
                        Kullanici k1 = new Kullanici();
                        k1.KullaniciAdi = txtUsername.Text;
                        k1.KullaniciPassword = hashedPwd; // Hashlenmiþ þifre kullanýcý nesnesine atanýyor
                        _db.Kullanicilar.Add(k1);
                        _db.SaveChanges();


                    }
                }
                else
                    MessageBox.Show("Giriþ baþarýþýz.");
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