using NutriGuide.Entity.Data;
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
                Kullanici kullanici = new Kullanici();  
                kullanici.KullaniciAdi = txtUsername.Text;
                kullanici.KullaniciPassword = txtPassword.Text;


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