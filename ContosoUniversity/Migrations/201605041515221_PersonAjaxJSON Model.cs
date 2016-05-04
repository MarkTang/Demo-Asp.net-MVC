namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PersonAjaxJSONModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonAjaxJSON",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PersonAjaxJSON");
        }
    }
}
