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
                Thread.Sleep(100);
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
                Thread.Sleep(100);
                sb.Append(text[i]);
                btnLogin.Text = sb.ToString();
                Refresh();
            }
            // subsequent wait period

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}