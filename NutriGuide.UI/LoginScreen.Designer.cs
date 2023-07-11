namespace NutriGuide.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            txtPassword = new TextBox();
            pictureBox2 = new PictureBox();
            lblSignUp = new Label();
            lblYazi = new Label();
            txtUsername = new TextBox();
            btnLogin = new Button();
            lblUserName = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.close_1;
            pictureBox1.Location = new Point(402, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(34, 40, 49);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Location = new Point(-9, -17);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1183, 600);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(238, 238, 238);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(lblSignUp);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblYazi);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(656, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 419);
            panel1.TabIndex = 12;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Window;
            pictureBox4.Image = Properties.Resources.user;
            pictureBox4.Location = new Point(368, 170);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 23);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Window;
            pictureBox5.Image = Properties.Resources.padlock;
            pictureBox5.Location = new Point(369, 253);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 23);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(23, 250);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(384, 28);
            txtPassword.TabIndex = 8;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(145, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignUp.ForeColor = Color.FromArgb(0, 173, 181);
            lblSignUp.Location = new Point(237, 367);
            lblSignUp.Margin = new Padding(4, 0, 4, 0);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(88, 18);
            lblSignUp.TabIndex = 6;
            lblSignUp.Text = "Sign Up!";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // lblYazi
            // 
            lblYazi.AutoSize = true;
            lblYazi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblYazi.ForeColor = Color.FromArgb(34, 40, 49);
            lblYazi.Location = new Point(83, 369);
            lblYazi.Margin = new Padding(4, 0, 4, 0);
            lblYazi.Name = "lblYazi";
            lblYazi.Size = new Size(146, 16);
            lblYazi.TabIndex = 5;
            lblYazi.Text = "Don't have an account?";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Courier New", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(23, 166);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(384, 28);
            txtUsername.TabIndex = 7;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(23, 300);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(386, 49);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.Transparent;
            lblUserName.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserName.ForeColor = Color.FromArgb(34, 40, 49);
            lblUserName.Location = new Point(23, 134);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(88, 18);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(34, 40, 49);
            label1.Location = new Point(23, 219);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(238, 238, 238);
            pictureBox3.Image = Properties.Resources.diet;
            pictureBox3.Location = new Point(67, 78);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(459, 335);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 173, 181);
            ClientSize = new Size(1160, 567);
            ControlBox = false;
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private TextBox txtPassword;
        private PictureBox pictureBox4;
        private Label lblUserName;
        private Label label1;
        private Button btnLogin;
        private TextBox txtUsername;
        private Label lblYazi;
        private Label lblSignUp;
        private Panel panel1;
    }
}