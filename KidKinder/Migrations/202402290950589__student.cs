namespace KidKinder.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _student : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Students", "ClassRoomId");
            AddForeignKey("dbo.Students", "ClassRoomId", "dbo.ClassRooms", "ClassRoomId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "ClassRoomId", "dbo.ClassRooms");
            DropIndex("dbo.Students", new[] { "ClassRoomId" });
        }
    }
}
