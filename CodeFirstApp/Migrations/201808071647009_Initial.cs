namespace CodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Street = c.String(),
                        City = c.String(),
                        HouseNumber = c.String(),
                        FlatNumber = c.String(),
                        Description = c.String(),
                        PostCode = c.String(),
                        Longtitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Latitude = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.OtherInfo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Value = c.String(),
                        Person_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.Person_Id)
                .Index(t => t.Person_Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        BirthDay = c.DateTime(storeType: "date"),
                        CreationTime = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PhoneEntry",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhoneNumber = c.String(nullable: false, maxLength: 20),
                        Prefix = c.String(maxLength: 5),
                        Description = c.String(),
                        OwnerId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Person", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhoneEntry", "OwnerId", "dbo.Person");
            DropForeignKey("dbo.OtherInfo", "Person_Id", "dbo.Person");
            DropForeignKey("dbo.Address", "Person_Id", "dbo.Person");
            DropIndex("dbo.PhoneEntry", new[] { "OwnerId" });
            DropIndex("dbo.OtherInfo", new[] { "Person_Id" });
            DropIndex("dbo.Address", new[] { "Person_Id" });
            DropTable("dbo.PhoneEntry");
            DropTable("dbo.Person");
            DropTable("dbo.OtherInfo");
            DropTable("dbo.Address");
        }
    }
}
