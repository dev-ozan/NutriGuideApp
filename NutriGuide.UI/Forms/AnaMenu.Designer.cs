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
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            listBox1 = new ListBox();
            label5 = new Label();
            label6 = new Label();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 162);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 3;
            label3.Text = "Kalori";
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
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Menu;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(271, 162);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 109);
            listBox1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(266, 91);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 8;
            label5.Text = "*******";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(268, 53);
            label6.Name = "label6";
            label6.Size = new Size(58, 20);
            label6.TabIndex = 7;
            label6.Text = "*******";
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 238, 238);
            ClientSize = new Size(525, 348);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private ListBox listBox1;
        private Label label5;
        private Label label6;
    }
}