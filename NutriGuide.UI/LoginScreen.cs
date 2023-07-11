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
            btnLogin.Text = "";
            string text = "SIGN UP";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                Thread.Sleep(50);
                sb.Append(text[i]);
                btnLogin.Text = sb.ToString();
                Refresh();
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
            // subsequent wait period
            if (btnLogin.Text == "LOGIN" && txtPassword.Text != "" && txtUsername.Text != "")
            {
                
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                // db ye kiþi eklenicek
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