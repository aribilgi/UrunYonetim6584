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
    }
}
