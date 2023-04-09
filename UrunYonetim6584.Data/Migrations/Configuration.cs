using System;
using System.Data.Entity.Migrations;
using System.Linq;

namespace UrunYonetim6584.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
            ContextKey = "UrunYonetim6584.Data.DatabaseContext";
        }

        protected override void Seed(DatabaseContext context)
        {
            //  This method will be called after migrating to the latest version.
            // seed metodu veritabanı oluştuktan sonra çalışır ve burada tablolara başlangıç kayıtları atabiliriz.
            if (!context.Users.Any()) // eğer veritabanında hiç kayıt yoksa
            {
                context.Users.Add(new Entities.User()
                { // db deki users tablosuna aşağıdaki kaydı ekle
                    CreateDate = DateTime.Now,
                    Email = "admin@6584.com",
                    IsActive = true,
                    IsAdmin = true,
                    Name = "admin",
                    Username = "admin",
                    Password = "123"
                });
                context.SaveChanges(); // değişiklikleri db ye işle
            }
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
