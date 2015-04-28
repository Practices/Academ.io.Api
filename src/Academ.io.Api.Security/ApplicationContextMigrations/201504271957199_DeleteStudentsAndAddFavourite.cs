namespace Academ.io.Api.Security.ApplicationContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteStudentsAndAddFavourite : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Students", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Students", new[] { "ApplicationUser_Id" });
            CreateTable(
                "dbo.Favourites",
                c => new
                    {
                        FavouriteId = c.Int(nullable: false, identity: true),
                        ContentId = c.Guid(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.FavouriteId)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            DropTable("dbo.Students");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Guid(nullable: false),
                        Firstname = c.String(),
                        Middlename = c.String(),
                        Lastname = c.String(),
                        Cardnumber = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        GroupId = c.Guid(nullable: false),
                        Group = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.StudentId);
            
            DropForeignKey("dbo.Favourites", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Favourites", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Favourites");
            CreateIndex("dbo.Students", "ApplicationUser_Id");
            AddForeignKey("dbo.Students", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
