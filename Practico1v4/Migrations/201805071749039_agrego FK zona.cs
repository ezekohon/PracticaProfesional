namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregoFKzona : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vendedores", "Zona_Id", "dbo.Zonas");
            DropIndex("dbo.Vendedores", new[] { "Zona_Id" });
            RenameColumn(table: "dbo.Vendedores", name: "Zona_Id", newName: "ZonaId");
            AlterColumn("dbo.Vendedores", "ZonaId", c => c.Int(nullable: true, defaultValue: 1));
            CreateIndex("dbo.Vendedores", "ZonaId");
            AddForeignKey("dbo.Vendedores", "ZonaId", "dbo.Zonas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendedores", "ZonaId", "dbo.Zonas");
            DropIndex("dbo.Vendedores", new[] { "ZonaId" });
            AlterColumn("dbo.Vendedores", "ZonaId", c => c.Int());
            RenameColumn(table: "dbo.Vendedores", name: "ZonaId", newName: "Zona_Id");
            CreateIndex("dbo.Vendedores", "Zona_Id");
            AddForeignKey("dbo.Vendedores", "Zona_Id", "dbo.Zonas", "Id");
        }
    }
}
