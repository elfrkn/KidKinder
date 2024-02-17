namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _news : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookASeats", "ClassRoom_ClassRoomId", "dbo.ClassRooms");
            DropIndex("dbo.BookASeats", new[] { "ClassRoom_ClassRoomId" });
            DropColumn("dbo.BookASeats", "ClassRoom_ClassRoomId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BookASeats", "ClassRoom_ClassRoomId", c => c.Int());
            CreateIndex("dbo.BookASeats", "ClassRoom_ClassRoomId");
            AddForeignKey("dbo.BookASeats", "ClassRoom_ClassRoomId", "dbo.ClassRooms", "ClassRoomId");
        }
    }
}
