namespace insecureDesign
{
    partial class ucGirisYap
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
            btnGirisYap = new Button();
            txtSifre = new TextBox();
            label4 = new Label();
            txtKullaniciAdi = new TextBox();
            label3 = new Label();
            cbRememberMe = new CheckBox();
            SuspendLayout();
            // 
            // btnGirisYap
            // 
            btnGirisYap.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnGirisYap.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnGirisYap.Location = new Point(426, 333);
            btnGirisYap.Margin = new Padding(6);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(329, 69);
            btnGirisYap.TabIndex = 17;
            btnGirisYap.Text = "Giriş yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSifre.Location = new Point(426, 157);
            txtSifre.Margin = new Padding(6);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(414, 46);
            txtSifre.TabIndex = 16;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(316, 163);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(79, 40);
            label4.TabIndex = 15;
            label4.Text = "Şifre:";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtKullaniciAdi.Location = new Point(426, 66);
            txtKullaniciAdi.Margin = new Padding(6);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(414, 46);
            txtKullaniciAdi.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(216, 69);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(179, 40);
            label3.TabIndex = 13;
            label3.Text = "Kullanıcı Adı:";
            // 
            // cbRememberMe
            // 
            cbRememberMe.AutoSize = true;
            cbRememberMe.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbRememberMe.Location = new Point(426, 245);
            cbRememberMe.Margin = new Padding(6);
            cbRememberMe.Name = "cbRememberMe";
            cbRememberMe.Size = new Size(216, 44);
            cbRememberMe.TabIndex = 18;
            cbRememberMe.Text = "Hesabı Hatırla";
            cbRememberMe.UseVisualStyleBackColor = true;
            cbRememberMe.CheckedChanged += cbRememberMe_CheckedChanged;
            // 
            // ucGirisYap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbRememberMe);
            Controls.Add(btnGirisYap);
            Controls.Add(txtSifre);
            Controls.Add(label4);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label3);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(6);
            Name = "ucGirisYap";
            Size = new Size(1088, 762);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGirisYap;
        private TextBox txtSifre;
        private Label label4;
        private TextBox txtKullaniciAdi;
        private Label label3;
        private CheckBox cbRememberMe;
    }
}
