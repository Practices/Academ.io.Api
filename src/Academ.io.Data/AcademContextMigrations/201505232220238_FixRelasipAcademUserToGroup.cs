namespace Academ.io.Data.AcademContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixRelasipAcademUserToGroup : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.GroupAcademUsers", newName: "AcademUserGroups");
            DropPrimaryKey("dbo.AcademUserGroups");
            AddPrimaryKey("dbo.AcademUserGroups", new[] { "AcademUser_AcademUserId", "Group_GroupId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.AcademUserGroups");
            AddPrimaryKey("dbo.AcademUserGroups", new[] { "Group_GroupId", "AcademUser_AcademUserId" });
            RenameTable(name: "dbo.AcademUserGroups", newName: "GroupAcademUsers");
        }
    }
}
