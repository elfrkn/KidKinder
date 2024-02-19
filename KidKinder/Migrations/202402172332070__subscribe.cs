namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _subscribe : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MailSubscribes", "EmailSubscribe", c => c.String());
            DropColumn("dbo.MailSubscribes", "Email");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MailSubscribes", "Email", c => c.String());
            DropColumn("dbo.MailSubscribes", "EmailSubscribe");
        }
    }
}
