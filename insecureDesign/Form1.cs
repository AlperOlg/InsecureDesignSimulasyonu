using DataAccessLayer.abstractt;
using DataAccessLayer.Entities;
using insecureDesign.appsettings;

namespace insecureDesign
{
    public partial class Form1 : Form
    {
        private readonly ucKayitOl _ucKayitOl;
        private readonly ucGirisYap _ucGirisYap;
        private readonly IUserDataAccess _iUserDAL;
        private User? _kullanici;
        public Form1(ucKayitOl ucKayitOl, ucGirisYap ucGirisYap, IUserDataAccess iUserDAL)
        {
            InitializeComponent();
            _ucKayitOl = ucKayitOl;
            _ucGirisYap = ucGirisYap;
            _iUserDAL = iUserDAL;

            _ucGirisYap.GirisYapildiMi += (s, kullanici) =>
            {
                GirisYap(kullanici);
            };
        }
        private void UserControlDegistir(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            pnlUC.Controls.Clear();
            pnlUC.Controls.Add(control);
        }
        private void GirisYap(User kullanici)
        {
            _kullanici = kullanici;
            lblHesapIsmi.Visible = true;
            btnCikisYap.Visible = true;
            lblHesapIsmi.Text = $"giriþ yapýlan hesap: {_kullanici.Name} {_kullanici.Surname}";
        }
        private void CikisYap()
        {
            _kullanici = null;
            lblHesapIsmi.Visible = false;
            lblHesapIsmi.Text = string.Empty;
            btnCikisYap.Visible = false;
            AyarlarYoneticisi.AyarlariKaydet(0);
        }
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            UserControlDegistir(_ucKayitOl);
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            UserControlDegistir(_ucGirisYap);
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hesaptan çýkýþ yapýlýyor", "soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CikisYap();
                UserControlDegistir(_ucGirisYap);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var ayarlar = AyarlarYoneticisi.AyarlariYukle();
            try
            {
                if (ayarlar.SonGirisYapilanHesapID <= 0)
                { return; }

                _kullanici = await _iUserDAL.KullaniciGetirAsync(ayarlar.SonGirisYapilanHesapID);
                if(_kullanici == null) 
                { return; }
                lblHesapIsmi.Visible = true;
                lblHesapIsmi.Text = $"giriþ yapýlan hesap: {_kullanici.Name} {_kullanici.Surname}";
                btnCikisYap.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("bir hata oluþtu: " + ex.Message);
            }
        }
    }
}
