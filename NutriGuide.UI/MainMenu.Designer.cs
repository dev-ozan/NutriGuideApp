namespace NutriGuide.UI
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnMenuSide = new Button();
            panel2 = new Panel();
            btnInfo = new Button();
            btnYemekler = new Button();
            btnDiyetPlan = new Button();
            btnProfile = new Button();
            btnAnaMenu = new Button();
            panel3 = new Panel();
            label2 = new Label();
            lblNutriGuide = new Label();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblSaat = new Label();
            lblKullaniciAd = new Label();
            pnlChildForm = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMenuSide
            // 
            btnMenuSide.BackColor = Color.FromArgb(34, 40, 49);
            btnMenuSide.Cursor = Cursors.Hand;
            btnMenuSide.FlatAppearance.BorderSize = 0;
            btnMenuSide.FlatStyle = FlatStyle.Flat;
            btnMenuSide.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnMenuSide.ForeColor = Color.FromArgb(238, 238, 238);
            btnMenuSide.Location = new Point(-2, -7);
            btnMenuSide.Margin = new Padding(4);
            btnMenuSide.Name = "btnMenuSide";
            btnMenuSide.Size = new Size(259, 88);
            btnMenuSide.TabIndex = 0;
            btnMenuSide.Text = "Menu";
            btnMenuSide.UseVisualStyleBackColor = false;
            btnMenuSide.Click += btnMenuSide_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnInfo);
            panel2.Controls.Add(btnYemekler);
            panel2.Controls.Add(btnDiyetPlan);
            panel2.Controls.Add(btnProfile);
            panel2.Controls.Add(btnAnaMenu);
            panel2.Location = new Point(0, 122);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(257, 282);
            panel2.TabIndex = 1;
            // 
            // btnInfo
            // 
            btnInfo.AutoEllipsis = true;
            btnInfo.BackColor = Color.FromArgb(34, 40, 49);
            btnInfo.Cursor = Cursors.Hand;
            btnInfo.FlatAppearance.BorderSize = 0;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.FromArgb(238, 238, 238);
            btnInfo.Image = Properties.Resources.info_6_32;
            btnInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnInfo.Location = new Point(13, 204);
            btnInfo.Margin = new Padding(4);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(244, 48);
            btnInfo.TabIndex = 4;
            btnInfo.Text = "               Hakkımızda";
            btnInfo.TextAlign = ContentAlignment.MiddleLeft;
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // btnYemekler
            // 
            btnYemekler.AutoEllipsis = true;
            btnYemekler.BackColor = Color.FromArgb(34, 40, 49);
            btnYemekler.Cursor = Cursors.Hand;
            btnYemekler.FlatAppearance.BorderSize = 0;
            btnYemekler.FlatStyle = FlatStyle.Flat;
            btnYemekler.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnYemekler.ForeColor = Color.FromArgb(238, 238, 238);
            btnYemekler.Image = Properties.Resources.restaurant_3_32;
            btnYemekler.ImageAlign = ContentAlignment.MiddleLeft;
            btnYemekler.Location = new Point(13, 148);
            btnYemekler.Margin = new Padding(4);
            btnYemekler.Name = "btnYemekler";
            btnYemekler.Size = new Size(244, 48);
            btnYemekler.TabIndex = 3;
            btnYemekler.Text = "               Yemekler";
            btnYemekler.TextAlign = ContentAlignment.MiddleLeft;
            btnYemekler.UseVisualStyleBackColor = false;
            btnYemekler.Click += btnYemekler_Click;
            // 
            // btnDiyetPlan
            // 
            btnDiyetPlan.AutoEllipsis = true;
            btnDiyetPlan.BackColor = Color.FromArgb(34, 40, 49);
            btnDiyetPlan.Cursor = Cursors.Hand;
            btnDiyetPlan.FlatAppearance.BorderSize = 0;
            btnDiyetPlan.FlatStyle = FlatStyle.Flat;
            btnDiyetPlan.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDiyetPlan.ForeColor = Color.FromArgb(238, 238, 238);
            btnDiyetPlan.Image = Properties.Resources.banana_3_32;
            btnDiyetPlan.ImageAlign = ContentAlignment.MiddleLeft;
            btnDiyetPlan.Location = new Point(13, 98);
            btnDiyetPlan.Margin = new Padding(4);
            btnDiyetPlan.Name = "btnDiyetPlan";
            btnDiyetPlan.Size = new Size(246, 48);
            btnDiyetPlan.TabIndex = 2;
            btnDiyetPlan.Text = "               Diyet Planı";
            btnDiyetPlan.TextAlign = ContentAlignment.MiddleLeft;
            btnDiyetPlan.UseVisualStyleBackColor = false;
            btnDiyetPlan.Click += btnDiyetPlan_Click;
            // 
            // btnProfile
            // 
            btnProfile.AutoEllipsis = true;
            btnProfile.BackColor = Color.FromArgb(34, 40, 49);
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.FlatAppearance.BorderSize = 0;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.FromArgb(238, 238, 238);
            btnProfile.Image = Properties.Resources.user_32;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(13, 49);
            btnProfile.Margin = new Padding(4);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(246, 48);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "               Profil";
            btnProfile.TextAlign = ContentAlignment.MiddleLeft;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnAnaMenu
            // 
            btnAnaMenu.AutoEllipsis = true;
            btnAnaMenu.BackColor = Color.FromArgb(34, 40, 49);
            btnAnaMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btnAnaMenu.Cursor = Cursors.Hand;
            btnAnaMenu.FlatAppearance.BorderSize = 0;
            btnAnaMenu.FlatStyle = FlatStyle.Flat;
            btnAnaMenu.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAnaMenu.ForeColor = Color.FromArgb(238, 238, 238);
            btnAnaMenu.Image = Properties.Resources.home_5_32;
            btnAnaMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnaMenu.Location = new Point(13, -8);
            btnAnaMenu.Margin = new Padding(4);
            btnAnaMenu.Name = "btnAnaMenu";
            btnAnaMenu.Size = new Size(246, 56);
            btnAnaMenu.TabIndex = 0;
            btnAnaMenu.Text = "               Ana Menu";
            btnAnaMenu.TextAlign = ContentAlignment.MiddleLeft;
            btnAnaMenu.UseVisualStyleBackColor = false;
            btnAnaMenu.Click += btnAnaMenu_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(34, 40, 49);
            panel3.Controls.Add(btnMenuSide);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(panel2);
            panel3.Location = new Point(0, 114);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 420);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 589);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // lblNutriGuide
            // 
            lblNutriGuide.BackColor = Color.FromArgb(34, 40, 49);
            lblNutriGuide.Font = new Font("Bauhaus 93", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblNutriGuide.ForeColor = Color.FromArgb(238, 238, 238);
            lblNutriGuide.Location = new Point(0, 0);
            lblNutriGuide.Margin = new Padding(4, 0, 4, 0);
            lblNutriGuide.Name = "lblNutriGuide";
            lblNutriGuide.Size = new Size(257, 114);
            lblNutriGuide.TabIndex = 4;
            lblNutriGuide.Text = "\r\nNutri Guide";
            lblNutriGuide.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 173, 181);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(pictureBox2);
            panel5.Controls.Add(pictureBox1);
            panel5.Controls.Add(panel1);
            panel5.Controls.Add(lblNutriGuide);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(994, 114);
            panel5.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.close__2_;
            pictureBox3.Location = new Point(965, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(29, 26);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(34, 40, 49);
            pictureBox2.Image = Properties.Resources.balanced_diet;
            pictureBox2.Location = new Point(101, 56);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(53, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.diet;
            pictureBox1.Location = new Point(421, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(209, 105);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSaat);
            panel1.Controls.Add(lblKullaniciAd);
            panel1.Location = new Point(710, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(198, 83);
            panel1.TabIndex = 5;
            // 
            // lblSaat
            // 
            lblSaat.BackColor = Color.FromArgb(0, 173, 181);
            lblSaat.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaat.ForeColor = Color.FromArgb(34, 40, 49);
            lblSaat.Location = new Point(3, 39);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(192, 28);
            lblSaat.TabIndex = 1;
            lblSaat.Text = "label3";
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.BackColor = Color.FromArgb(0, 173, 181);
            lblKullaniciAd.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAd.ForeColor = Color.FromArgb(34, 40, 49);
            lblKullaniciAd.Location = new Point(3, 9);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(192, 28);
            lblKullaniciAd.TabIndex = 0;
            lblKullaniciAd.Text = "label3";
            // 
            // pnlChildForm
            // 
            pnlChildForm.Location = new Point(257, 114);
            pnlChildForm.Name = "pnlChildForm";
            pnlChildForm.Size = new Size(737, 420);
            pnlChildForm.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 219, 234);
            ClientSize = new Size(994, 531);
            Controls.Add(pnlChildForm);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "MainMenu";
            Text = "MainMenu";
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnMenuSide;
        private Panel panel2;
        private Button btnYemekler;
        private Button btnDiyetPlan;
        private Button btnProfile;
        private Button btnAnaMenu;
        private Panel panel3;
        private Label lblNutriGuide;
        private Panel panel5;
        private Label label2;
        private Panel panel1;
        private Label lblKullaniciAd;
        private Panel pnlChildForm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnInfo;
        private System.Windows.Forms.Timer timer1;
        private Label lblSaat;
    }
}