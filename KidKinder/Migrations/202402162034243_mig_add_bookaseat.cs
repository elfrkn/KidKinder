namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_bookaseat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookASeats", "ClassRoomId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.BookASeats", "ClassRoomId");
        }
    }
}
