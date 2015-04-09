namespace Academ.io.Data.StudentContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
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
                    })
                .PrimaryKey(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
