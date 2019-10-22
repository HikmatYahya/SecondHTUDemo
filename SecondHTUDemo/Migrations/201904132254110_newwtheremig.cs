namespace SecondHTUDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newwtheremig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 256));
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String());
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            DropColumn("dbo.Students", "Email");
        }
    }
}
