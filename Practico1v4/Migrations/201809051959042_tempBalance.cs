namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tempBalance : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tempBalances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tipo = c.Int(nullable: false),
                        CodigoBalance = c.String(),
                        CodigoPadre = c.String(),
                        Nombre = c.String(),
                        SaldoInicial = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Debitos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Creditos = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaldoAcumulado = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SaldoCierre = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tempBalances");
        }
    }
}
