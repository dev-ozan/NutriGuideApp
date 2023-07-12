namespace NutriGuide.UI.Forms
{
    partial class AnaMenu
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
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lblKalori = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            lstTuketilenler = new ListBox();
            lblAdSoyad = new Label();
            lblKullaniciAd = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(177, 53);
            label1.Name = "label1";
            label1.Size = new Size(94, 18);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(184, 91);
            label2.Name = "label2";
            label2.Size = new Size(87, 18);
            label2.TabIndex = 1;
            label2.Text = "Adı Soyadı:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.userDefault;
            pictureBox1.Location = new Point(36, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblKalori
            // 
            lblKalori.AutoSize = true;
            lblKalori.Location = new Point(64, 162);
            lblKalori.Name = "lblKalori";
            lblKalori.Size = new Size(37, 15);
            lblKalori.TabIndex = 3;
            lblKalori.Text = "Kalori";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(174, 162);
            label4.Name = "label4";
            label4.Size = new Size(91, 18);
            label4.TabIndex = 4;
            label4.Text = "Tüketilenler:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.calories;
            pictureBox2.Location = new Point(36, 180);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 68);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // lstTuketilenler
            // 
            lstTuketilenler.BackColor = SystemColors.Menu;
            lstTuketilenler.FormattingEnabled = true;
            lstTuketilenler.ItemHeight = 15;
            lstTuketilenler.Location = new Point(271, 162);
            lstTuketilenler.Name = "lstTuketilenler";
            lstTuketilenler.Size = new Size(162, 109);
            lstTuketilenler.TabIndex = 6;
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblAdSoyad.Location = new Point(266, 91);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(58, 20);
            lblAdSoyad.TabIndex = 8;
            lblAdSoyad.Text = "*******";
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lblKullaniciAd.Location = new Point(268, 53);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(58, 20);
            lblKullaniciAd.TabIndex = 7;
            lblKullaniciAd.Text = "*******";
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(525, 348);
            Controls.Add(lblAdSoyad);
            Controls.Add(lblKullaniciAd);
            Controls.Add(lstTuketilenler);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(lblKalori);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AnaMenu";
            Text = "AnaMenu";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblKalori;
        private Label label4;
        private PictureBox pictureBox2;
        private ListBox lstTuketilenler;
        private Label lblAdSoyad;
        private Label lblKullaniciAd;
    }
}