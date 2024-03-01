namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migchange : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Galleries", "BigImageUrl");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Galleries", "BigImageUrl", c => c.String());
        }
    }
}
