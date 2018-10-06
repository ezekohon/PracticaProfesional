namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aver : DbMigration
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
