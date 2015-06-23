namespace Academ.io.Api.Security.ApplicationContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Favourites", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Favourites", new[] { "ApplicationUser_Id" });
            DropTable("dbo.Favourites");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Favourites",
                c => new
                    {
                        FavouriteId = c.Int(nullable: false, identity: true),
                        ContentId = c.Guid(nullable: false),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.FavouriteId);
            
            CreateIndex("dbo.Favourites", "ApplicationUser_Id");
            AddForeignKey("dbo.Favourites", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
        }
    }
}
