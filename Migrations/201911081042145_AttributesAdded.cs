namespace _08_11_2019WeekendTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttributesAdded : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Projects", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Projects", "PublishDate", c => c.DateTime(nullable: false, storeType: "date"));
            AlterColumn("dbo.Projects", "Description", c => c.String(nullable: false, storeType: "ntext"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Projects", "Description", c => c.String(nullable: false));
            AlterColumn("dbo.Projects", "PublishDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Projects", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Categories", "Name", c => c.String());
        }
    }
}
