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
            btnLogin = new Button();
            lblUserName = new Label();
            label1 = new Label();
            lblYazi = new Label();
            lblSignUp = new Label();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.Location = new Point(10, 281);
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
            lblUserName.Location = new Point(10, 115);
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
            label1.Location = new Point(10, 200);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 4;
            label1.Text = "Password";
            // 
            // lblYazi
            // 
            lblYazi.AutoSize = true;
            lblYazi.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblYazi.ForeColor = Color.FromArgb(34, 40, 49);
            lblYazi.Location = new Point(70, 350);
            lblYazi.Margin = new Padding(4, 0, 4, 0);
            lblYazi.Name = "lblYazi";
            lblYazi.Size = new Size(146, 16);
            lblYazi.TabIndex = 5;
            lblYazi.Text = "Don't have an account?";
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Courier New", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSignUp.ForeColor = Color.FromArgb(0, 173, 181);
            lblSignUp.Location = new Point(224, 348);
            lblSignUp.Margin = new Padding(4, 0, 4, 0);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(88, 18);
            lblSignUp.TabIndex = 6;
            lblSignUp.Text = "Sign Up!";
            lblSignUp.Click += lblSignUp_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.Window;
            pictureBox5.Image = Properties.Resources.padlock;
            pictureBox5.Location = new Point(362, 229);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.Window;
            pictureBox4.Image = Properties.Resources.user;
            pictureBox4.Location = new Point(362, 144);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources._lock;
            pictureBox2.Location = new Point(124, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(158, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtPassword.Location = new Point(10, 229);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(384, 31);
            txtPassword.TabIndex = 8;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtUsername.Location = new Point(10, 144);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(384, 31);
            txtUsername.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.close_1;
            pictureBox1.Location = new Point(1128, 12);
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
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1160, 567);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(238, 238, 238);
            groupBox2.Controls.Add(pictureBox5);
            groupBox2.Controls.Add(txtPassword);
            groupBox2.Controls.Add(pictureBox4);
            groupBox2.Controls.Add(lblUserName);
            groupBox2.Controls.Add(pictureBox2);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(btnLogin);
            groupBox2.Controls.Add(txtUsername);
            groupBox2.Controls.Add(lblYazi);
            groupBox2.Controls.Add(lblSignUp);
            groupBox2.Location = new Point(656, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(401, 452);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(238, 238, 238);
            pictureBox3.Image = Properties.Resources.diet;
            pictureBox3.Location = new Point(132, 58);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(527, 452);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnLogin;
        private Label lblUserName;
        private Label label1;
        private Label lblYazi;
        private Label lblSignUp;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox3;
    }
}