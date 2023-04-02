using System.Data.Entity;
using UrunYonetim6584.Entities;

namespace UrunYonetim6584.Data
{
    public class DatabaseContext : DbContext // DbContext class ı nuget dan yüklediğimiz entityframework den geliyor
    {
        public DbSet<Category> Categories { get; set; } // veritabanı tablolarımızı temsil eden dbset ler
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
        public DatabaseContext() : base("name=UrunYonetimiDb")
        {
            Database.SetInitializer(new DbInitializer()); // DbInitializer classımızı bu şekilde kurucu metotta çağırıyoruz çalışması için
        }
        // model değişikliği durumlarında veritabanını silme gibi sorunlar yaşamamak için migration sistemi kullanılır!
        // Migration kullanmak için Tools menüsünden Nuget package manager > package manager console menüsüne tıklayıp komut çalıştırma alanını aşağıya getiriyoruz.
        // Bu alanda default project kısmından Data proje katmanını seçiyoruz
        // Komut yazma alanına enable-migrations yazıp enter a basıyoruz
        // Migration sistemi aktif olduktan sonra artık db yi silmemize gerek yok
        // update-database komutunu yazıp enter diyerek güncellemeleri db ye yansıtabiliriz
        // köklü bir değişiklik yaptığımızda ise add-migration migrationismi şeklinde komut yazıp enter deyip tekrar update-database komutuyla daha büyük değişiklikleri de db ye yansıtabiliriz.
    }
}
