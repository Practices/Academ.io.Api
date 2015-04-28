namespace Academ.io.Data.StudentContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentCollectUserStudent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserStudents",
                c => new
                    {
                        UserStudentId = c.Guid(nullable: false),
                        Student_StudentId = c.Guid(),
                    })
                .PrimaryKey(t => t.UserStudentId)
                .ForeignKey("dbo.Students", t => t.Student_StudentId)
                .Index(t => t.Student_StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserStudents", "Student_StudentId", "dbo.Students");
            DropIndex("dbo.UserStudents", new[] { "Student_StudentId" });
            DropTable("dbo.UserStudents");
        }
    }
}
