namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renglon : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Renglones",
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
                        Sucursal = c.String(),
                        Seccion = c.Int(nullable: false),
                        esDebeHaber = c.Int(nullable: false),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Leyenda = c.String(),
                        OK_Carga = c.Int(nullable: false),
                        Registrado = c.Int(nullable: false),
                        Tipo = c.Int(nullable: false),
                        Cuenta_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cuentas", t => t.Cuenta_Id)
                .Index(t => t.Cuenta_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Renglones", "Cuenta_Id", "dbo.Cuentas");
            DropIndex("dbo.Renglones", new[] { "Cuenta_Id" });
            DropTable("dbo.Renglones");
        }
    }
}
