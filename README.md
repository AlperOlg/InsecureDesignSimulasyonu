# InsecureDesignSimulasyonu
# InsecureDesignSimulasyonu
Insecure Design Örneği: Kimlik Doğrulama Zafiyeti
# Proje Hakkında
Uygulama; Dependency Injection (DI), Service Collection, Entity Framework Core ve Event-Driven Design prensipleriyle katmanlı mimaride inşa edilmiştir.
## Kullanılan Teknolojiler
- Dil: C# 12 / .NET 8
- ORM: Entity Framework Core (Code First)
- Veritabanı: MS SQL Server
- Mimari: Katmanlı Mimari (DataAccessLayer & UI)
- Tasarım: UserControl bazlı dinamik form yapısı
- Güvenlik Zafiyeti Analizi:
Bu uygulama, kasıtlı olarak tasarlanmış 3 temel güvenlik açığı içermektedir:
1. Güvensiz Yerel Depolama : "Beni Hatırla" özelliği, kullanıcı oturumunu doğrulamak için sadece yerel bir `Ayarlar.json` dosyasındaki `ID` değerine  şifrelenmeden konulmuştur. Sunucu tarafında bu ID'nin bütünlüğü kontrol edilmez.
2. plaintext Parolalar : Şifreler veritabanına herhangi bir hashleme işleminden geçirilmeden ham halde kaydedilir.
3. Unique Olmayan Kimlik Bilgileri: Kullanıcı adları veritabanı seviyesinde unique değildir, bu durum kimlik karmaşasına yol açabilir.
