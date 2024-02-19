namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _relation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BookASeats", "ClassRoomId", c => c.Int(nullable: false));
            CreateIndex("dbo.BookASeats", "ClassRoomId");
            AddForeignKey("dbo.BookASeats", "ClassRoomId", "dbo.ClassRooms", "ClassRoomId", cascadeDelete: true);
            DropColumn("dbo.BookASeats", "ClassCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookASeats", "ClassCategory", c => c.Int(nullable: false));
            DropForeignKey("dbo.BookASeats", "ClassRoomId", "dbo.ClassRooms");
            DropIndex("dbo.BookASeats", new[] { "ClassRoomId" });
            DropColumn("dbo.BookASeats", "ClassRoomId");
        }
    }
}
