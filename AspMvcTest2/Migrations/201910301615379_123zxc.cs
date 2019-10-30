namespace AspMvcTest2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _123zxc : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Users", name: "RoleId", newName: "Id");
            RenameIndex(table: "dbo.Users", name: "IX_RoleId", newName: "IX_Id");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Users", name: "IX_Id", newName: "IX_RoleId");
            RenameColumn(table: "dbo.Users", name: "Id", newName: "RoleId");
        }
    }
}
