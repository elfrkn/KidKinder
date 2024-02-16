namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_change_bookaseat : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookASeats", "ClassCategory", c => c.Int(nullable: false));
            DropColumn("dbo.BookASeats", "ClassRoomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookASeats", "ClassRoomId", c => c.Int(nullable: false));
            DropColumn("dbo.BookASeats", "ClassCategory");
        }
    }
}
