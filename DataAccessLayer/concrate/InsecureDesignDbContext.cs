using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.concrate
{
    public class InsecureDesignDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=InsecureDesignDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasKey(u => u.ID);
            modelBuilder.Entity<User>().Property(u => u.Name).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Surname).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.Password).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<User>().Property(u => u.NickName).HasMaxLength(150).IsRequired();
            modelBuilder.Entity<User>().HasIndex(u => u.NickName); //.IsUnique(); bu durumda en güvenli seçenek kullanıcı adını eşsiz yapmamızdır ama şuan aynı kullanıcı adına sahip birden fazla hesap oluşmasına izin vereriyoruz yani kimlik doğrulama süreçlerinde tutarsızlığa ve yetki aşımına yol açabilir.

        }
    }
}
