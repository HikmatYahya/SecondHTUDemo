namespace SecondHTUDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oneOneMIG : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(maxLength: 256),
                        LastName = c.String(maxLength: 256),
                        ApplicationUserId = c.String(maxLength: 128),
                        Country = c.String(),
                        City = c.String(),
                        IsApproved = c.Boolean(nullable: false),
                        SkillsLookingFor = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            CreateTable(
                "dbo.HTUStuffs",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(maxLength: 256),
                        LastName = c.String(maxLength: 256),
                        ApplicationUserId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUserId)
                .Index(t => t.ApplicationUserId);
            
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 256));
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HTUStuffs", "ApplicationUserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Employees", "ApplicationUserId", "dbo.AspNetUsers");
            DropIndex("dbo.HTUStuffs", new[] { "ApplicationUserId" });
            DropIndex("dbo.Employees", new[] { "ApplicationUserId" });
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            DropTable("dbo.HTUStuffs");
            DropTable("dbo.Employees");
        }
    }
}
