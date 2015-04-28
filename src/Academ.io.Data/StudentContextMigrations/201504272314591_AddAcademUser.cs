namespace Academ.io.Data.StudentContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAcademUser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserStudents", "Student_StudentId", "dbo.Students");
            DropIndex("dbo.UserStudents", new[] { "Student_StudentId" });
            CreateTable(
                "dbo.AcademUsers",
                c => new
                    {
                        AcademUserId = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.AcademUserId);
            
            AddColumn("dbo.Students", "AcademUser_AcademUserId", c => c.Int());
            CreateIndex("dbo.Students", "AcademUser_AcademUserId");
            AddForeignKey("dbo.Students", "AcademUser_AcademUserId", "dbo.AcademUsers", "AcademUserId");
            DropTable("dbo.UserStudents");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserStudents",
                c => new
                    {
                        UserStudentId = c.Guid(nullable: false),
                        Student_StudentId = c.Guid(),
                    })
                .PrimaryKey(t => t.UserStudentId);
            
            DropForeignKey("dbo.Students", "AcademUser_AcademUserId", "dbo.AcademUsers");
            DropIndex("dbo.Students", new[] { "AcademUser_AcademUserId" });
            DropColumn("dbo.Students", "AcademUser_AcademUserId");
            DropTable("dbo.AcademUsers");
            CreateIndex("dbo.UserStudents", "Student_StudentId");
            AddForeignKey("dbo.UserStudents", "Student_StudentId", "dbo.Students", "StudentId");
        }
    }
}
