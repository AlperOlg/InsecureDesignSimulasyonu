using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace insecureDesign.appsettings
{
    public class AyarlarYoneticisi
    {
        private static string dosyaYolu = "Ayarlar.json"; 
        public static void AyarlariKaydet(int kullaniciID)
        {
            var ayarlar = new Ayarlar() { SonGirisYapilanHesapID = kullaniciID };
            string jsonString = JsonSerializer.Serialize(ayarlar);
            File.WriteAllText(dosyaYolu, jsonString);
        }
        public static Ayarlar AyarlariYukle()
        {
            if (!File.Exists(dosyaYolu)) return new Ayarlar();

            string jsonString = File.ReadAllText(dosyaYolu);
            return JsonSerializer.Deserialize<Ayarlar>(jsonString) ?? new Ayarlar();
        }
    }
}
