namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _delparentid : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "ParentId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Students", "ParentId", c => c.Int(nullable: false));
        }
    }
}
