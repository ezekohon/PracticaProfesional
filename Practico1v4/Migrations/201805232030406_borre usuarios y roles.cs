namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class borreusuariosyroles : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UsuarioRols", "Usuario_Id", "dbo.Usuarios");
            DropForeignKey("dbo.UsuarioRols", "Rol_Id", "dbo.Roles");
            DropIndex("dbo.Usuarios", new[] { "Username" });
            DropIndex("dbo.UsuarioRols", new[] { "Usuario_Id" });
            DropIndex("dbo.UsuarioRols", new[] { "Rol_Id" });
            DropTable("dbo.Roles");
            DropTable("dbo.Usuarios");
            DropTable("dbo.UsuarioRols");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UsuarioRols",
                c => new
                    {
                        Usuario_Id = c.Int(nullable: false),
                        Rol_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Usuario_Id, t.Rol_Id });
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 200),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Privilegio = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.UsuarioRols", "Rol_Id");
            CreateIndex("dbo.UsuarioRols", "Usuario_Id");
            CreateIndex("dbo.Usuarios", "Username", unique: true);
            AddForeignKey("dbo.UsuarioRols", "Rol_Id", "dbo.Roles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.UsuarioRols", "Usuario_Id", "dbo.Usuarios", "Id", cascadeDelete: true);
        }
    }
}
