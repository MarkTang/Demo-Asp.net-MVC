namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Ageintisntnull : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PersonAjaxJSON", "Age", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PersonAjaxJSON", "Age", c => c.Int(nullable: false));
        }
    }
}
