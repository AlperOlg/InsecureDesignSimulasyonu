namespace insecureDesign
{
    partial class ucKayitOl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtIsim = new TextBox();
            txtSoyisim = new TextBox();
            label2 = new Label();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            txtSifre = new TextBox();
            label4 = new Label();
            btnKayitOl = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(248, 24);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 40);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // txtIsim
            // 
            txtIsim.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtIsim.Location = new Point(346, 18);
            txtIsim.Margin = new Padding(6);
            txtIsim.Name = "txtIsim";
            txtIsim.Size = new Size(522, 46);
            txtIsim.TabIndex = 1;
            // 
            // txtSoyisim
            // 
            txtSoyisim.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyisim.Location = new Point(346, 88);
            txtSoyisim.Margin = new Padding(6);
            txtSoyisim.Name = "txtSoyisim";
            txtSoyisim.Size = new Size(522, 46);
            txtSoyisim.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(203, 91);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 40);
            label2.TabIndex = 2;
            label2.Text = "Soyisim:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(346, 170);
            txtKullaniciAdi.Margin = new Padding(6);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(522, 46);
            txtKullaniciAdi.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(144, 170);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 40);
            label3.TabIndex = 4;
            label3.Text = "Kullanıcı Adı:";
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(346, 249);
            txtSifre.Margin = new Padding(6);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(522, 46);
            txtSifre.TabIndex = 7;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(232, 249);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 40);
            label4.TabIndex = 6;
            label4.Text = "Şifre:";
            // 
            // btnKayitOl
            // 
            btnKayitOl.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnKayitOl.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnKayitOl.Location = new Point(357, 343);
            btnKayitOl.Margin = new Padding(6);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(476, 71);
            btnKayitOl.TabIndex = 8;
            btnKayitOl.Text = "Kayıt ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // ucKayitOl
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnKayitOl);
            Controls.Add(txtSifre);
            Controls.Add(label4);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label3);
            Controls.Add(txtSoyisim);
            Controls.Add(label2);
            Controls.Add(txtIsim);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(6);
            Name = "ucKayitOl";
            Size = new Size(1091, 670);
            Load += ucKayitOl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIsim;
        private TextBox txtSoyisim;
        private Label label2;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private TextBox txtSifre;
        private Label label4;
        private Button btnKayitOl;
    }
}
