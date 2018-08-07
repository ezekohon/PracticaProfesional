namespace Practico1v4.MigrationsTenants
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregocamposdeempresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tenants", "FechaInicioEjercicioContable", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tenants", "FechaCierreEjercicioContable", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tenants", "FechaImpresionUltimoDiario", c => c.DateTime(nullable: false));
            AddColumn("dbo.Tenants", "CUIT", c => c.Long(nullable: false));
            AddColumn("dbo.Tenants", "RazonSocial", c => c.String());
            AddColumn("dbo.Tenants", "SituacionFrenteAIVA", c => c.String());
            AddColumn("dbo.Tenants", "DireccionFisica", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tenants", "DireccionFisica");
            DropColumn("dbo.Tenants", "SituacionFrenteAIVA");
            DropColumn("dbo.Tenants", "RazonSocial");
            DropColumn("dbo.Tenants", "CUIT");
            DropColumn("dbo.Tenants", "FechaImpresionUltimoDiario");
            DropColumn("dbo.Tenants", "FechaCierreEjercicioContable");
            DropColumn("dbo.Tenants", "FechaInicioEjercicioContable");
        }
    }
}
