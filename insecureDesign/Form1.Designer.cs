namespace insecureDesign
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
            label1 = new Label();
            panel1 = new Panel();
            btnCikisYap = new Button();
            btnGirisYap = new Button();
            btnKayitOl = new Button();
            pnlUC = new Panel();
            lblHesapIsmi = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 16);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 32);
            label1.TabIndex = 0;
            label1.Text = "Siber Güvenlik Toolu";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCikisYap);
            panel1.Controls.Add(btnGirisYap);
            panel1.Controls.Add(btnKayitOl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 63);
            panel1.TabIndex = 1;
            // 
            // btnCikisYap
            // 
            btnCikisYap.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            btnCikisYap.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            btnCikisYap.FlatStyle = FlatStyle.Flat;
            btnCikisYap.Location = new Point(782, 12);
            btnCikisYap.Name = "btnCikisYap";
            btnCikisYap.Size = new Size(124, 42);
            btnCikisYap.TabIndex = 3;
            btnCikisYap.Text = "Çıkış yap";
            btnCikisYap.UseVisualStyleBackColor = true;
            btnCikisYap.Visible = false;
            btnCikisYap.Click += btnCikisYap_Click;
            // 
            // btnGirisYap
            // 
            btnGirisYap.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnGirisYap.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnGirisYap.FlatStyle = FlatStyle.Flat;
            btnGirisYap.Location = new Point(442, 10);
            btnGirisYap.Name = "btnGirisYap";
            btnGirisYap.Size = new Size(124, 42);
            btnGirisYap.TabIndex = 2;
            btnGirisYap.Text = "Giriş yap";
            btnGirisYap.UseVisualStyleBackColor = true;
            btnGirisYap.Click += btnGirisYap_Click;
            // 
            // btnKayitOl
            // 
            btnKayitOl.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 255, 128);
            btnKayitOl.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 192);
            btnKayitOl.FlatStyle = FlatStyle.Flat;
            btnKayitOl.Location = new Point(277, 12);
            btnKayitOl.Name = "btnKayitOl";
            btnKayitOl.Size = new Size(124, 42);
            btnKayitOl.TabIndex = 1;
            btnKayitOl.Text = "Kayıt ol";
            btnKayitOl.UseVisualStyleBackColor = true;
            btnKayitOl.Click += btnKayitOl_Click;
            // 
            // pnlUC
            // 
            pnlUC.Location = new Point(12, 129);
            pnlUC.Name = "pnlUC";
            pnlUC.Size = new Size(1169, 621);
            pnlUC.TabIndex = 2;
            // 
            // lblHesapIsmi
            // 
            lblHesapIsmi.AutoSize = true;
            lblHesapIsmi.Location = new Point(18, 94);
            lblHesapIsmi.Margin = new Padding(6, 0, 6, 0);
            lblHesapIsmi.Name = "lblHesapIsmi";
            lblHesapIsmi.Size = new Size(57, 32);
            lblHesapIsmi.TabIndex = 4;
            lblHesapIsmi.Text = "isim";
            lblHesapIsmi.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1193, 762);
            Controls.Add(lblHesapIsmi);
            Controls.Add(pnlUC);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Margin = new Padding(6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button btnKayitOl;
        private Button btnCikisYap;
        private Button btnGirisYap;
        private Panel pnlUC;
        private Label lblHesapIsmi;
    }
}
