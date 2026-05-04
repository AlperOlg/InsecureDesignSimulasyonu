using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.abstractt
{
    public interface IUserDataAccess
    {
        Task KullaniciKayitEtAsync(User user);
        Task<User> KullaniciGirisYapAsync(string kullaniciAdi, string sifre);
        Task<User> KullaniciGetirAsync(int ID);
    }
}
