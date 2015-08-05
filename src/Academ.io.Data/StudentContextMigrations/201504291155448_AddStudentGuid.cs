namespace Academ.io.Data.StudentContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStudentGuid : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "StudentIdentity", c => c.Guid(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "StudentIdentity");
        }
    }
}
