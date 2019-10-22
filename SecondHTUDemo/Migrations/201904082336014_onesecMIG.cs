namespace SecondHTUDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class onesecMIG : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "FirstName", c => c.String());
            AlterColumn("dbo.Students", "LastName", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "LastName", c => c.String(maxLength: 256));
            AlterColumn("dbo.Students", "FirstName", c => c.String(maxLength: 256));
        }
    }
}
