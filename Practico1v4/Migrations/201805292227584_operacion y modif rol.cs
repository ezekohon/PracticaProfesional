namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class operacionymodifrol : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RolOperacions",
                c => new
                    {
                        Rol_Id = c.Int(nullable: false),
                        Operacion_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Rol_Id, t.Operacion_Id })
                .ForeignKey("dbo.Roles", t => t.Rol_Id, cascadeDelete: true)
                .ForeignKey("dbo.Operaciones", t => t.Operacion_Id, cascadeDelete: true)
                .Index(t => t.Rol_Id)
                .Index(t => t.Operacion_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RolOperacions", "Operacion_Id", "dbo.Operaciones");
            DropForeignKey("dbo.RolOperacions", "Rol_Id", "dbo.Roles");
            DropIndex("dbo.RolOperacions", new[] { "Operacion_Id" });
            DropIndex("dbo.RolOperacions", new[] { "Rol_Id" });
            DropTable("dbo.RolOperacions");
            DropTable("dbo.Operaciones");
        }
    }
}
