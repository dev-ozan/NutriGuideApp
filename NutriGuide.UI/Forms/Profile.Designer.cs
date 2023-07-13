namespace NutriGuide.UI.Forms
{
    partial class Profile
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            txtBoy = new TextBox();
            txtKilo = new TextBox();
            txtHedefKilo = new TextBox();
            dtpDogumTarih = new DateTimePicker();
            lblKullaniciAd = new Label();
            label10 = new Label();
            cmbCinsiyet = new ComboBox();
            btnGuncelle = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(98, 159);
            label2.Name = "label2";
            label2.Size = new Size(32, 18);
            label2.TabIndex = 0;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(70, 204);
            label3.Name = "label3";
            label3.Size = new Size(57, 18);
            label3.TabIndex = 1;
            label3.Text = "Soyad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(23, 250);
            label4.Name = "label4";
            label4.Size = new Size(104, 18);
            label4.TabIndex = 2;
            label4.Text = "Doğum Tarihi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(465, 159);
            label5.Name = "label5";
            label5.Size = new Size(39, 18);
            label5.TabIndex = 3;
            label5.Text = "Boy:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(465, 204);
            label6.Name = "label6";
            label6.Size = new Size(39, 18);
            label6.TabIndex = 4;
            label6.Text = "Kilo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(418, 250);
            label7.Name = "label7";
            label7.Size = new Size(85, 18);
            label7.TabIndex = 5;
            label7.Text = "Hedef Kilo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(36, 71);
            label8.Name = "label8";
            label8.Size = new Size(94, 18);
            label8.TabIndex = 6;
            label8.Text = "Kullanıcı Adı:";
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.Location = new Point(142, 157);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(182, 25);
            txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.Location = new Point(142, 202);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(182, 25);
            txtSoyad.TabIndex = 8;
            // 
            // txtBoy
            // 
            txtBoy.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoy.Location = new Point(517, 157);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(182, 25);
            txtBoy.TabIndex = 9;
            txtBoy.Text = "0";
            // 
            // txtKilo
            // 
            txtKilo.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtKilo.Location = new Point(517, 202);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(182, 25);
            txtKilo.TabIndex = 10;
            txtKilo.Text = "0";
            // 
            // txtHedefKilo
            // 
            txtHedefKilo.Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHedefKilo.Location = new Point(517, 248);
            txtHedefKilo.Name = "txtHedefKilo";
            txtHedefKilo.Size = new Size(182, 25);
            txtHedefKilo.TabIndex = 11;
            txtHedefKilo.Text = "0";
            // 
            // dtpDogumTarih
            // 
            dtpDogumTarih.CalendarFont = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDogumTarih.CustomFormat = "dd.MM.yyyy";
            dtpDogumTarih.Format = DateTimePickerFormat.Short;
            dtpDogumTarih.Location = new Point(142, 248);
            dtpDogumTarih.Name = "dtpDogumTarih";
            dtpDogumTarih.Size = new Size(182, 25);
            dtpDogumTarih.TabIndex = 12;
            dtpDogumTarih.Value = new DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // lblKullaniciAd
            // 
            lblKullaniciAd.AutoSize = true;
            lblKullaniciAd.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblKullaniciAd.Location = new Point(142, 71);
            lblKullaniciAd.Name = "lblKullaniciAd";
            lblKullaniciAd.Size = new Size(62, 18);
            lblKullaniciAd.TabIndex = 13;
            lblKullaniciAd.Text = "*********";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(56, 297);
            label10.Name = "label10";
            label10.Size = new Size(68, 18);
            label10.TabIndex = 14;
            label10.Text = "Cinsiyet:";
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kiz" });
            cmbCinsiyet.Location = new Point(142, 295);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(182, 25);
            cmbCinsiyet.TabIndex = 15;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(517, 369);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(182, 39);
            btnGuncelle.TabIndex = 16;
            btnGuncelle.Text = "Bilgileri Güncelle";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(231, 206, 166);
            ClientSize = new Size(823, 432);
            Controls.Add(btnGuncelle);
            Controls.Add(cmbCinsiyet);
            Controls.Add(label10);
            Controls.Add(lblKullaniciAd);
            Controls.Add(dtpDogumTarih);
            Controls.Add(txtHedefKilo);
            Controls.Add(txtKilo);
            Controls.Add(txtBoy);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Font = new Font("Arial", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Profile";
            Text = "Profile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private TextBox txtBoy;
        private TextBox txtKilo;
        private TextBox txtHedefKilo;
        private DateTimePicker dtpDogumTarih;
        private Label lblKullaniciAd;
        private Label label10;
        private ComboBox cmbCinsiyet;
        private Button btnGuncelle;
    }
}