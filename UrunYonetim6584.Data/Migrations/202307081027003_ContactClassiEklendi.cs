namespace UrunYonetim6584.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ContactClassiEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(),
                        Telephone = c.Int(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Message = c.String(nullable: false, maxLength: 1500),
                        CreateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Contacts");
        }
    }
}
