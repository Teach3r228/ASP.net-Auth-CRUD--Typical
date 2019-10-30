namespace AspMvcTest2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameRoleIdtoId : DbMigration
    {
        public override void Up()
        {
            /*DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropPrimaryKey("dbo.Roles");
            AddColumn("dbo.Roles", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Roles", "Id");
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "Id");
            DropColumn("dbo.Roles", "RoleId");*/
        }
        
        public override void Down()
        {
            /*AddColumn("dbo.Roles", "RoleId", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Users", "RoleId", "dbo.Roles");
            DropPrimaryKey("dbo.Roles");
            DropColumn("dbo.Roles", "Id");
            AddPrimaryKey("dbo.Roles", "RoleId");
            AddForeignKey("dbo.Users", "RoleId", "dbo.Roles", "RoleId");*/
        }
    }
}
