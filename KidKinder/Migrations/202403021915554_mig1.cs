namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutLists",
                c => new
                    {
                        AboutListId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AboutListId);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        AboutBigImageUrl = c.String(),
                        Header = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        SmallImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.AboutId);
            
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        AdminId = c.Int(nullable: false, identity: true),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.AdminId);
            
            CreateTable(
                "dbo.BookASeats",
                c => new
                    {
                        BookASeatId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Class = c.String(),
                    })
                .PrimaryKey(t => t.BookASeatId);
            
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.BranchID);
            
            CreateTable(
                "dbo.Teachers",
                c => new
                    {
                        TeacherId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        ImageUrl = c.String(),
                        BranchID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TeacherId)
                .ForeignKey("dbo.Branches", t => t.BranchID, cascadeDelete: true)
                .Index(t => t.BranchID);
            
            CreateTable(
                "dbo.ClassRooms",
                c => new
                    {
                        ClassRoomId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        AgeOfKids = c.String(),
                        TotalSeat = c.Byte(nullable: false),
                        ClassTime = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.ClassRoomId);
            
            CreateTable(
                "dbo.Communications",
                c => new
                    {
                        CommunicationId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.CommunicationId);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        ContactId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                        Subject = c.String(),
                        Message = c.String(),
                        SenDate = c.DateTime(nullable: false),
                        IsRead = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ContactId);
            
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Header = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.FeatureId);
            
            CreateTable(
                "dbo.MailSubscribes",
                c => new
                    {
                        MailSubscribeId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.MailSubscribeId);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        NotificationId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        NatifacationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.NotificationId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        IconUrl = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.Testimonials",
                c => new
                    {
                        TestimonialId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                        NameSurname = c.String(),
                        Title = c.String(),
                        Comment = c.String(),
                    })
                .PrimaryKey(t => t.TestimonialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "BranchID", "dbo.Branches");
            DropIndex("dbo.Teachers", new[] { "BranchID" });
            DropTable("dbo.Testimonials");
            DropTable("dbo.Services");
            DropTable("dbo.Notifications");
            DropTable("dbo.MailSubscribes");
            DropTable("dbo.Features");
            DropTable("dbo.Contacts");
            DropTable("dbo.Communications");
            DropTable("dbo.ClassRooms");
            DropTable("dbo.Teachers");
            DropTable("dbo.Branches");
            DropTable("dbo.BookASeats");
            DropTable("dbo.Admins");
            DropTable("dbo.Abouts");
            DropTable("dbo.AboutLists");
        }
    }
}
