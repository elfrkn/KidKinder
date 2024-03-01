namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _migrealtion : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Parents", "StudentId");
            AddForeignKey("dbo.Parents", "StudentId", "dbo.Students", "StudentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Parents", "StudentId", "dbo.Students");
            DropIndex("dbo.Parents", new[] { "StudentId" });
        }
    }
}
