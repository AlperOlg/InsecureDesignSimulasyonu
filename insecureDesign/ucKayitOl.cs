using DataAccessLayer.abstractt;
using DataAccessLayer.Entities;
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
    public partial class ucKayitOl : UserControl
    {
        private readonly IUserDataAccess _iUserDAL;
        public ucKayitOl(IUserDataAccess iUserDAL)
        {
            InitializeComponent();
            _iUserDAL = iUserDAL;
        }

        private void ucKayitOl_Load(object sender, EventArgs e)
        {

        }
        private void InputlarıTemizle()
        {
            txtKullaniciAdi.Text = string.Empty;
            txtSifre.Text = string.Empty;
            txtIsim.Text = string.Empty;
            txtSoyisim.Text = string.Empty;
        }
        private async void btnKayitOl_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIsim.Text) || string.IsNullOrWhiteSpace(txtKullaniciAdi.Text) || string.IsNullOrWhiteSpace(txtSifre.Text) || string.IsNullOrWhiteSpace(txtSoyisim.Text))
            { MessageBox.Show("Boş bilgi bırakmayın"); return; }
            User user = new User()
            {
                Name = txtIsim.Text,
                Surname = txtSoyisim.Text,
                NickName = txtKullaniciAdi.Text,
                Password = txtSifre.Text
            };
            try
            {
                await _iUserDAL.KullaniciKayitEtAsync(user);
                MessageBox.Show("Kullanıcı kayıt edildi");
                InputlarıTemizle();
            }
            catch (Exception ex) { MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message); InputlarıTemizle(); }
        }
    }
}
