namespace Academ.io.Data.SessionContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefactoringMarkAndTestType : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Marks", "TestTypeId", "dbo.TestTypes");
            DropIndex("dbo.Marks", new[] { "TestTypeId" });
            RenameColumn(table: "dbo.Marks", name: "TestTypeId", newName: "TestType_TestTypeId");
            AddColumn("dbo.Marks", "Grade", c => c.Int(nullable: false));
            AddColumn("dbo.Marks", "Name", c => c.String());
            AddColumn("dbo.Marks", "ShortName", c => c.String());
            AddColumn("dbo.TestTypes", "Name", c => c.String());
            AddColumn("dbo.TestTypes", "ShortName", c => c.String());
            AlterColumn("dbo.Marks", "TestType_TestTypeId", c => c.Int());
            CreateIndex("dbo.Marks", "TestType_TestTypeId");
            AddForeignKey("dbo.Marks", "TestType_TestTypeId", "dbo.TestTypes", "TestTypeId");
            DropColumn("dbo.Marks", "GradeMark");
            DropColumn("dbo.Marks", "Title");
            DropColumn("dbo.Marks", "TitleShort");
            DropColumn("dbo.TestTypes", "Title");
            DropColumn("dbo.TestTypes", "TitleShort");
        }
        
        public override void Down()
        {
            AddColumn("dbo.TestTypes", "TitleShort", c => c.String());
            AddColumn("dbo.TestTypes", "Title", c => c.String());
            AddColumn("dbo.Marks", "TitleShort", c => c.String());
            AddColumn("dbo.Marks", "Title", c => c.String());
            AddColumn("dbo.Marks", "GradeMark", c => c.Int(nullable: false));
            DropForeignKey("dbo.Marks", "TestType_TestTypeId", "dbo.TestTypes");
            DropIndex("dbo.Marks", new[] { "TestType_TestTypeId" });
            AlterColumn("dbo.Marks", "TestType_TestTypeId", c => c.Int(nullable: false));
            DropColumn("dbo.TestTypes", "ShortName");
            DropColumn("dbo.TestTypes", "Name");
            DropColumn("dbo.Marks", "ShortName");
            DropColumn("dbo.Marks", "Name");
            DropColumn("dbo.Marks", "Grade");
            RenameColumn(table: "dbo.Marks", name: "TestType_TestTypeId", newName: "TestTypeId");
            CreateIndex("dbo.Marks", "TestTypeId");
            AddForeignKey("dbo.Marks", "TestTypeId", "dbo.TestTypes", "TestTypeId", cascadeDelete: true);
        }
    }
}
