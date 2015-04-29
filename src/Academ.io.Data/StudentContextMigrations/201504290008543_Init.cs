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
                        StudentId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Middlename = c.String(),
                        Lastname = c.String(),
                        Cardnumber = c.String(),
                        Birthdate = c.DateTime(nullable: false),
                        GroupId = c.Guid(nullable: false),
                        Group = c.String(),
                    })
                .PrimaryKey(t => t.StudentId);
            
            CreateTable(
                "dbo.AcademUsers",
                c => new
                    {
                        AcademUserId = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.AcademUserId);
            
            CreateTable(
                "dbo.AcademUserStudents",
                c => new
                    {
                        AcademUser_AcademUserId = c.Int(nullable: false),
                        Student_StudentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.AcademUser_AcademUserId, t.Student_StudentId })
                .ForeignKey("dbo.AcademUsers", t => t.AcademUser_AcademUserId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.Student_StudentId, cascadeDelete: true)
                .Index(t => t.AcademUser_AcademUserId)
                .Index(t => t.Student_StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AcademUserStudents", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.AcademUserStudents", "AcademUser_AcademUserId", "dbo.AcademUsers");
            DropIndex("dbo.AcademUserStudents", new[] { "Student_StudentId" });
            DropIndex("dbo.AcademUserStudents", new[] { "AcademUser_AcademUserId" });
            DropTable("dbo.AcademUserStudents");
            DropTable("dbo.AcademUsers");
            DropTable("dbo.Students");
        }
    }
}
