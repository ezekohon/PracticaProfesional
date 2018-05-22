namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uniqueconstraintusername : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "Username", c => c.String(nullable: false, maxLength: 200));
            CreateIndex("dbo.Usuarios", "Username", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Usuarios", new[] { "Username" });
            AlterColumn("dbo.Usuarios", "Username", c => c.String(nullable: false));
        }
    }
}
