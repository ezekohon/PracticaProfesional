namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agreguePuntoDeVentaIDaVendedores : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Vendedores", name: "PuntoDeVenta_Id", newName: "PuntoDeVentaId");
            RenameIndex(table: "dbo.Vendedores", name: "IX_PuntoDeVenta_Id", newName: "IX_PuntoDeVentaId");
        }
        
        public override void Down()
        {
            RenameIndex(table: "dbo.Vendedores", name: "IX_PuntoDeVentaId", newName: "IX_PuntoDeVenta_Id");
            RenameColumn(table: "dbo.Vendedores", name: "PuntoDeVentaId", newName: "PuntoDeVenta_Id");
        }
    }
}
