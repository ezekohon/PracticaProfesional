namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class codigosastringv2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Clientes", "Codigo", c => c.String());
            AlterColumn("dbo.Clientes", "CUIT", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Clientes", "CUIT", c => c.Long(nullable: false));
            AlterColumn("dbo.Clientes", "Codigo", c => c.Long(nullable: false));
        }
    }
}
