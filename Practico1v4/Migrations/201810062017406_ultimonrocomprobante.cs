namespace Practico1v4.MigrationsTenants
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ultimonrocomprobante : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tenants", "UltimoNroComprobante", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tenants", "UltimoNroComprobante");
        }
    }
}
