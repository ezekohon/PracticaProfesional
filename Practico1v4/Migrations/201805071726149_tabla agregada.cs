namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablaagregada : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Zonas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Vendedores", "Zona_Id", c => c.Int());
            CreateIndex("dbo.Vendedores", "Zona_Id");
            AddForeignKey("dbo.Vendedores", "Zona_Id", "dbo.Zonas", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendedores", "Zona_Id", "dbo.Zonas");
            DropIndex("dbo.Vendedores", new[] { "Zona_Id" });
            DropColumn("dbo.Vendedores", "Zona_Id");
            DropTable("dbo.Zonas");
        }
    }
}
