namespace _08_11_2019WeekendTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesModified : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Project_Id", "dbo.Projects");
            DropIndex("dbo.Categories", new[] { "Project_Id" });
            DropColumn("dbo.Categories", "Project_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Project_Id", c => c.Int());
            CreateIndex("dbo.Categories", "Project_Id");
            AddForeignKey("dbo.Categories", "Project_Id", "dbo.Projects", "Id");
        }
    }
}
