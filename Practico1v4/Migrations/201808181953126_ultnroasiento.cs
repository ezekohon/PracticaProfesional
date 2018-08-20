namespace Practico1v4.MigrationsTenants
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ultnroasiento : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tenants", "UltimoNroAsientoCargando", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tenants", "UltimoNroAsientoCargando");
        }
    }
}
