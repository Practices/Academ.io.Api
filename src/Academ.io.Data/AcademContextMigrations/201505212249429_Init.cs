namespace Academ.io.Data.AcademContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AcademUsers",
                c => new
                    {
                        AcademUserId = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.AcademUserId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Int(nullable: false, identity: true),
                        StudentIdentity = c.Guid(nullable: false),
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
                "dbo.Marks",
                c => new
                    {
                        MarkId = c.Int(nullable: false, identity: true),
                        Grade = c.Int(nullable: false),
                        Name = c.String(),
                        ShortName = c.String(),
                        TestType_TestTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.MarkId)
                .ForeignKey("dbo.TestTypes", t => t.TestType_TestTypeId)
                .Index(t => t.TestType_TestTypeId);
            
            CreateTable(
                "dbo.TestTypes",
                c => new
                    {
                        TestTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ShortName = c.String(),
                    })
                .PrimaryKey(t => t.TestTypeId);
            
            CreateTable(
                "dbo.SessionPoints",
                c => new
                    {
                        SessionPointId = c.Int(nullable: false, identity: true),
                        AveragePoint = c.Int(nullable: false),
                        LastPassDate = c.DateTime(nullable: false),
                        Session_SessionId = c.Int(),
                        Student_StudentId = c.Int(),
                    })
                .PrimaryKey(t => t.SessionPointId)
                .ForeignKey("dbo.Sessions", t => t.Session_SessionId)
                .ForeignKey("dbo.Students", t => t.Student_StudentId)
                .Index(t => t.Session_SessionId)
                .Index(t => t.Student_StudentId);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        SessionId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OpenDate = c.DateTime(nullable: false),
                        CloseDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.SessionId);
            
            CreateTable(
                "dbo.StudentAcademUsers",
                c => new
                    {
                        Student_StudentId = c.Int(nullable: false),
                        AcademUser_AcademUserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_StudentId, t.AcademUser_AcademUserId })
                .ForeignKey("dbo.Students", t => t.Student_StudentId, cascadeDelete: true)
                .ForeignKey("dbo.AcademUsers", t => t.AcademUser_AcademUserId, cascadeDelete: true)
                .Index(t => t.Student_StudentId)
                .Index(t => t.AcademUser_AcademUserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SessionPoints", "Student_StudentId", "dbo.Students");
            DropForeignKey("dbo.SessionPoints", "Session_SessionId", "dbo.Sessions");
            DropForeignKey("dbo.Marks", "TestType_TestTypeId", "dbo.TestTypes");
            DropForeignKey("dbo.StudentAcademUsers", "AcademUser_AcademUserId", "dbo.AcademUsers");
            DropForeignKey("dbo.StudentAcademUsers", "Student_StudentId", "dbo.Students");
            DropIndex("dbo.StudentAcademUsers", new[] { "AcademUser_AcademUserId" });
            DropIndex("dbo.StudentAcademUsers", new[] { "Student_StudentId" });
            DropIndex("dbo.SessionPoints", new[] { "Student_StudentId" });
            DropIndex("dbo.SessionPoints", new[] { "Session_SessionId" });
            DropIndex("dbo.Marks", new[] { "TestType_TestTypeId" });
            DropTable("dbo.StudentAcademUsers");
            DropTable("dbo.Sessions");
            DropTable("dbo.SessionPoints");
            DropTable("dbo.TestTypes");
            DropTable("dbo.Marks");
            DropTable("dbo.Students");
            DropTable("dbo.AcademUsers");
        }
    }
}
