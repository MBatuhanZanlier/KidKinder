namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        NameSurname = c.String(),
                        BranchID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Branches", t => t.BranchID, cascadeDelete: true)
                .Index(t => t.BranchID);
            
            AddColumn("dbo.ClassRooms", "BranchID", c => c.Int(nullable: false));
            CreateIndex("dbo.ClassRooms", "BranchID");
            AddForeignKey("dbo.ClassRooms", "BranchID", "dbo.Branches", "BranchID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "BranchID", "dbo.Branches");
            DropForeignKey("dbo.ClassRooms", "BranchID", "dbo.Branches");
            DropIndex("dbo.Students", new[] { "BranchID" });
            DropIndex("dbo.ClassRooms", new[] { "BranchID" });
            DropColumn("dbo.ClassRooms", "BranchID");
            DropTable("dbo.Students");
        }
    }
}
