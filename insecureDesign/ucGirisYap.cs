using DataAccessLayer.abstractt;
using DataAccessLayer.Entities;
using insecureDesign.appsettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace insecureDesign
{
    public partial class ucGirisYap : UserControl
    {
        private readonly IUserDataAccess _iUserDAL;
        public event EventHandler<User> GirisYapildiMi;
        private User? Kullanici;
        public ucGirisYap(IUserDataAccess iUserDAL)
        {
            InitializeComponent();
            _iUserDAL = iUserDAL;
        }
        private void InputlarıTemizle()
        {
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
        }
        public User? GetUser()
        {
            if (Kullanici == null)
            {
                return null;
            }
            return Kullanici;
        }
        private async void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            { MessageBox.Show("boş bilgi bırakılmamalı"); return; }
            Kullanici = await _iUserDAL.KullaniciGirisYapAsync(txtKullaniciAdi.Text, txtSifre.Text);
            if (Kullanici != null)
            {
                if (cbRememberMe.Checked)
                {
                    AyarlarYoneticisi.AyarlariKaydet(Kullanici.ID);
                }
                else
                {
                    AyarlarYoneticisi.AyarlariKaydet(0);
                }
                MessageBox.Show($"Hoşgeldin {Kullanici.Name} {Kullanici.Surname}");
                GirisYapildiMi.Invoke(this, Kullanici);
                InputlarıTemizle();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
                InputlarıTemizle();
            }
        }

        private void cbRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
