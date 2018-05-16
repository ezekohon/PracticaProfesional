namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKrequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Vendedores", "PuntoDeVenta_Id", "dbo.PuntoDeVentas");
            DropIndex("dbo.Vendedores", new[] { "PuntoDeVenta_Id" });
            AlterColumn("dbo.Vendedores", "PuntoDeVenta_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Vendedores", "PuntoDeVenta_Id");
            AddForeignKey("dbo.Vendedores", "PuntoDeVenta_Id", "dbo.PuntoDeVentas", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vendedores", "PuntoDeVenta_Id", "dbo.PuntoDeVentas");
            DropIndex("dbo.Vendedores", new[] { "PuntoDeVenta_Id" });
            AlterColumn("dbo.Vendedores", "PuntoDeVenta_Id", c => c.Int());
            CreateIndex("dbo.Vendedores", "PuntoDeVenta_Id");
            AddForeignKey("dbo.Vendedores", "PuntoDeVenta_Id", "dbo.PuntoDeVentas", "Id");
        }
    }
}
