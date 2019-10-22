namespace SecondHTUDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secHt : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Email", c => c.String());
            AddColumn("dbo.Employees", "Phone", c => c.String());
            AddColumn("dbo.HTUStuffs", "Email", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.HTUStuffs", "Email");
            DropColumn("dbo.Employees", "Phone");
            DropColumn("dbo.Employees", "Email");
        }
    }
}
