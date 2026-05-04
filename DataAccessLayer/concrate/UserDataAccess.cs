using DataAccessLayer.abstractt;
using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.concrate
{
    public class UserDataAccess : IUserDataAccess
    {
        private readonly IDbContextFactory<InsecureDesignDbContext> _contextFactory;
        public UserDataAccess(IDbContextFactory<InsecureDesignDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<User?> KullaniciGirisYapAsync(string kullaniciAdi, string sifre)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            User? user = await context.Users.FirstOrDefaultAsync(u => u.NickName == kullaniciAdi && u.Password == sifre);
            if (user == null)
            { return null; }
            else { return user; }

        }

        public async Task KullaniciKayitEtAsync(User user)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            await context.Users.AddAsync(user); 
            await context.SaveChangesAsync();
        }
        public async Task<User> KullaniciGetirAsync(int ID)
        {
            using var context = await _contextFactory.CreateDbContextAsync();
            User? kullanici = await context.Users.FindAsync(ID);
            if(kullanici == null) { throw new NullReferenceException("KullaniciGetir metotu null döndürdü"); }
            return kullanici;
        }

    }
}
