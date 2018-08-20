namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tablasnuevas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DiarioMayors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FechaContabilidad = c.DateTime(nullable: false),
                        NumeroAsiento = c.Int(nullable: false),
                        NumeroRenglon = c.Int(nullable: false),
                        IdCuenta = c.Int(nullable: false),
                        FechaVencimiento = c.DateTime(nullable: false),
                        FechaOperacion = c.DateTime(nullable: false),
                        Comprobante = c.String(),
                        Debe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Haber = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Leyenda = c.String(),
                        Registrado = c.Int(nullable: false),
                        Tipo = c.Int(nullable: false),
                        Cuenta_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cuentas", t => t.Cuenta_Id)
                .Index(t => t.Cuenta_Id);
            
            CreateTable(
                "dbo.UltimoDiarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UltimaFechaImpresion = c.DateTime(nullable: false),
                        UltimoNumeroFolio = c.Int(nullable: false),
                        UltimoNumeroAsiento = c.Int(nullable: false),
                        UltimoNumeroRenglon = c.Int(nullable: false),
                        UltimoNumeroTransporte = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DiarioMayors", "Cuenta_Id", "dbo.Cuentas");
            DropIndex("dbo.DiarioMayors", new[] { "Cuenta_Id" });
            DropTable("dbo.UltimoDiarios");
            DropTable("dbo.DiarioMayors");
        }
    }
}
