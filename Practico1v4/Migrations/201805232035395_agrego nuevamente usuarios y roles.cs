namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregonuevamenteusuariosyroles : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Privilegio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 200),
                        Password = c.String(nullable: false),
                        RolId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roles", t => t.RolId, cascadeDelete: true)
                .Index(t => t.Username, unique: true)
                .Index(t => t.RolId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "RolId", "dbo.Roles");
            DropIndex("dbo.Usuarios", new[] { "RolId" });
            DropIndex("dbo.Usuarios", new[] { "Username" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
        }
    }
}
