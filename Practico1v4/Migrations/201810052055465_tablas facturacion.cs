namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablasfacturacion : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articuloes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Descripcion = c.String(),
                        CantidadEnExistencia = c.Long(nullable: false),
                        CostoUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrecioNetoVenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TasaIVAId = c.Int(nullable: false),
                        TipoImpuestoInterno = c.Int(nullable: false),
                        ValorImpuestoInterno = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TasaIVAs", t => t.TasaIVAId, cascadeDelete: true)
                .Index(t => t.TasaIVAId);
            
            CreateTable(
                "dbo.TasaIVAs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Descripcion = c.String(),
                        Porcentaje = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Nombre = c.String(),
                        RazonSocial = c.String(),
                        Domicilio = c.String(),
                        CUIT = c.Long(nullable: false),
                        SituacionIVAId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SituacionIVAs", t => t.SituacionIVAId, cascadeDelete: true)
                .Index(t => t.SituacionIVAId);
            
            CreateTable(
                "dbo.SituacionIVAs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Descripcion = c.String(),
                        Sigla = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComprobanteEncabezadoPies",
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
                "dbo.Tenants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Host = c.String(),
                        BaseDeDatos = c.String(),
                        ConnectionString = c.String(),
                        FechaInicioEjercicioContable = c.DateTime(nullable: false),
                        FechaCierreEjercicioContable = c.DateTime(nullable: false),
                        FechaImpresionUltimoDiario = c.DateTime(nullable: false),
                        CUIT = c.Long(nullable: false),
                        RazonSocial = c.String(),
                        SituacionFrenteAIVA = c.String(),
                        DireccionFisica = c.String(),
                        UltimoNroAsientoCargando = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TipoComprobanteVentas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.Long(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ComprobanteRenglons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ComprobanteEncabezadoPieId = c.Int(nullable: false),
                        ArticuloId = c.Int(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Articuloes", t => t.ArticuloId, cascadeDelete: true)
                .ForeignKey("dbo.ComprobanteEncabezadoPies", t => t.ComprobanteEncabezadoPieId, cascadeDelete: true)
                .Index(t => t.ComprobanteEncabezadoPieId)
                .Index(t => t.ArticuloId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComprobanteRenglons", "ComprobanteEncabezadoPieId", "dbo.ComprobanteEncabezadoPies");
            DropForeignKey("dbo.ComprobanteRenglons", "ArticuloId", "dbo.Articuloes");
            DropForeignKey("dbo.ComprobanteEncabezadoPies", "TiposComprobantesVentaId", "dbo.TipoComprobanteVentas");
            DropForeignKey("dbo.ComprobanteEncabezadoPies", "TenantId", "dbo.Tenants");
            DropForeignKey("dbo.ComprobanteEncabezadoPies", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "SituacionIVAId", "dbo.SituacionIVAs");
            DropForeignKey("dbo.Articuloes", "TasaIVAId", "dbo.TasaIVAs");
            DropIndex("dbo.ComprobanteRenglons", new[] { "ArticuloId" });
            DropIndex("dbo.ComprobanteRenglons", new[] { "ComprobanteEncabezadoPieId" });
            DropIndex("dbo.ComprobanteEncabezadoPies", new[] { "TiposComprobantesVentaId" });
            DropIndex("dbo.ComprobanteEncabezadoPies", new[] { "ClienteId" });
            DropIndex("dbo.ComprobanteEncabezadoPies", new[] { "TenantId" });
            DropIndex("dbo.Clientes", new[] { "SituacionIVAId" });
            DropIndex("dbo.Articuloes", new[] { "TasaIVAId" });
            DropTable("dbo.ComprobanteRenglons");
            DropTable("dbo.TipoComprobanteVentas");
            DropTable("dbo.Tenants");
            DropTable("dbo.ComprobanteEncabezadoPies");
            DropTable("dbo.SituacionIVAs");
            DropTable("dbo.Clientes");
            DropTable("dbo.TasaIVAs");
            DropTable("dbo.Articuloes");
        }
    }
}
