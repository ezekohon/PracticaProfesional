namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usuariosyroles : DbMigration
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
                        Username = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UsuarioRols",
                c => new
                    {
                        Usuario_Id = c.Int(nullable: false),
                        Rol_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_Id, t.Rol_Id })
                .ForeignKey("dbo.Usuarios", t => t.Usuario_Id, cascadeDelete: true)
                .ForeignKey("dbo.Roles", t => t.Rol_Id, cascadeDelete: true)
                .Index(t => t.Usuario_Id)
                .Index(t => t.Rol_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UsuarioRols", "Rol_Id", "dbo.Roles");
            DropForeignKey("dbo.UsuarioRols", "Usuario_Id", "dbo.Usuarios");
            DropIndex("dbo.UsuarioRols", new[] { "Rol_Id" });
            DropIndex("dbo.UsuarioRols", new[] { "Usuario_Id" });
            DropTable("dbo.UsuarioRols");
            DropTable("dbo.Usuarios");
            DropTable("dbo.Roles");
        }
    }
}
