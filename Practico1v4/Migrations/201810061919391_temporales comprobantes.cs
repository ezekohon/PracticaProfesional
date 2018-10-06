namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class temporalescomprobantes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tempComprobanteEncabezadoPies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TenantId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        FechaEmision = c.DateTime(nullable: false),
                        TiposComprobantesVentaId = c.Int(nullable: false),
                        NumeroComprobante = c.Long(nullable: false),
                        Neto21 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IVA21 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Neto27 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IVA27 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Exento = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NoGravado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IVARNI = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Retenciones = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Tenants", t => t.TenantId, cascadeDelete: true)
                .ForeignKey("dbo.TipoComprobanteVentas", t => t.TiposComprobantesVentaId, cascadeDelete: true)
                .Index(t => t.TenantId)
                .Index(t => t.ClienteId)
                .Index(t => t.TiposComprobantesVentaId);
            
            CreateTable(
                "dbo.tempComprobanteRenglons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        tempComprobanteEncabezadoPieId = c.Int(nullable: false),
                        ArticuloId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articuloes", t => t.ArticuloId, cascadeDelete: true)
                .ForeignKey("dbo.tempComprobanteEncabezadoPies", t => t.tempComprobanteEncabezadoPieId, cascadeDelete: true)
                .Index(t => t.tempComprobanteEncabezadoPieId)
                .Index(t => t.ArticuloId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tempComprobanteRenglons", "tempComprobanteEncabezadoPieId", "dbo.tempComprobanteEncabezadoPies");
            DropForeignKey("dbo.tempComprobanteRenglons", "ArticuloId", "dbo.Articuloes");
            DropForeignKey("dbo.tempComprobanteEncabezadoPies", "TiposComprobantesVentaId", "dbo.TipoComprobanteVentas");
            DropForeignKey("dbo.tempComprobanteEncabezadoPies", "TenantId", "dbo.Tenants");
            DropForeignKey("dbo.tempComprobanteEncabezadoPies", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.tempComprobanteRenglons", new[] { "ArticuloId" });
            DropIndex("dbo.tempComprobanteRenglons", new[] { "tempComprobanteEncabezadoPieId" });
            DropIndex("dbo.tempComprobanteEncabezadoPies", new[] { "TiposComprobantesVentaId" });
            DropIndex("dbo.tempComprobanteEncabezadoPies", new[] { "ClienteId" });
            DropIndex("dbo.tempComprobanteEncabezadoPies", new[] { "TenantId" });
            DropTable("dbo.tempComprobanteRenglons");
            DropTable("dbo.tempComprobanteEncabezadoPies");
        }
    }
}
