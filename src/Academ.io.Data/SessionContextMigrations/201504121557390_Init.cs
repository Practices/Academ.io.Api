namespace Academ.io.Data.SessionContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Marks",
                c => new
                    {
                        MarkId = c.Int(nullable: false, identity: true),
                        GradeMark = c.Int(nullable: false),
                        Title = c.String(),
                        TitleShort = c.String(),
                        TestTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MarkId)
                .ForeignKey("dbo.TestTypes", t => t.TestTypeId, cascadeDelete: true)
                .Index(t => t.TestTypeId);
            
            CreateTable(
                "dbo.TestTypes",
                c => new
                    {
                        TestTypeId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        TitleShort = c.String(),
                    })
                .PrimaryKey(t => t.TestTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Marks", "TestTypeId", "dbo.TestTypes");
            DropIndex("dbo.Marks", new[] { "TestTypeId" });
            DropTable("dbo.TestTypes");
            DropTable("dbo.Marks");
        }
    }
}
