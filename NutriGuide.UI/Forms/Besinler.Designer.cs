namespace NutriGuide.UI.Forms
{
    partial class Besinler
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
            cmbDiyetler = new ComboBox();
            lblToplamKalori = new Label();
            btnEkle = new Button();
            btnCikar = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lblProtein = new Label();
            lblYag = new Label();
            lblKarbonhidrat = new Label();
            lstYemekler = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 88);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Diyetler:";
            // 
            // cmbDiyetler
            // 
            cmbDiyetler.FormattingEnabled = true;
            cmbDiyetler.Location = new Point(90, 85);
            cmbDiyetler.Name = "cmbDiyetler";
            cmbDiyetler.Size = new Size(197, 28);
            cmbDiyetler.TabIndex = 1;
            // 
            // lblToplamKalori
            // 
            lblToplamKalori.AutoSize = true;
            lblToplamKalori.Location = new Point(155, 149);
            lblToplamKalori.Margin = new Padding(4, 0, 4, 0);
            lblToplamKalori.Name = "lblToplamKalori";
            lblToplamKalori.Size = new Size(45, 20);
            lblToplamKalori.TabIndex = 4;
            lblToplamKalori.Text = "label4";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(463, 281);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(95, 35);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "Yemek Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(575, 281);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(95, 35);
            btnCikar.TabIndex = 6;
            btnCikar.Text = "Yemek Çıkar";
            btnCikar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 7;
            label2.Text = "Toplam Kalori:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 194);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(96, 20);
            label3.TabIndex = 8;
            label3.Text = "Alacağı Miktar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(166, 194);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 9;
            label5.Text = "Karbonhidrat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(278, 194);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 10;
            label6.Text = "Yağ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(349, 194);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 20);
            label7.TabIndex = 11;
            label7.Text = "Protein";
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(349, 229);
            lblProtein.Margin = new Padding(4, 0, 4, 0);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(34, 20);
            lblProtein.TabIndex = 14;
            lblProtein.Text = "*****";
            // 
            // lblYag
            // 
            lblYag.AutoSize = true;
            lblYag.Location = new Point(278, 229);
            lblYag.Margin = new Padding(4, 0, 4, 0);
            lblYag.Name = "lblYag";
            lblYag.Size = new Size(34, 20);
            lblYag.TabIndex = 13;
            lblYag.Text = "*****";
            // 
            // lblKarbonhidrat
            // 
            lblKarbonhidrat.AutoSize = true;
            lblKarbonhidrat.Location = new Point(166, 229);
            lblKarbonhidrat.Margin = new Padding(4, 0, 4, 0);
            lblKarbonhidrat.Name = "lblKarbonhidrat";
            lblKarbonhidrat.Size = new Size(34, 20);
            lblKarbonhidrat.TabIndex = 12;
            lblKarbonhidrat.Text = "*****";
            // 
            // lstYemekler
            // 
            lstYemekler.FormattingEnabled = true;
            lstYemekler.ItemHeight = 20;
            lstYemekler.Location = new Point(463, 25);
            lstYemekler.Name = "lstYemekler";
            lstYemekler.Size = new Size(207, 224);
            lstYemekler.TabIndex = 15;
            // 
            // Besinler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 191, 224);
            ClientSize = new Size(721, 381);
            Controls.Add(lstYemekler);
            Controls.Add(lblProtein);
            Controls.Add(lblYag);
            Controls.Add(lblKarbonhidrat);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCikar);
            Controls.Add(btnEkle);
            Controls.Add(lblToplamKalori);
            Controls.Add(cmbDiyetler);
            Controls.Add(label1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Besinler";
            Text = "Besinler";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbDiyetler;
        private Label lblToplamKalori;
        private Button btnEkle;
        private Button btnCikar;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lblProtein;
        private Label lblYag;
        private Label lblKarbonhidrat;
        private ListBox lstYemekler;
    }
}