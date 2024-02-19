namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _change2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookASeats", "ClassRoomId", "dbo.ClassRooms");
            DropIndex("dbo.BookASeats", new[] { "ClassRoomId" });
        }
        
        public override void Down()
        {
            CreateIndex("dbo.BookASeats", "ClassRoomId");
            AddForeignKey("dbo.BookASeats", "ClassRoomId", "dbo.ClassRooms", "ClassRoomId", cascadeDelete: true);
        }
    }
}
