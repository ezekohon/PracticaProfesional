namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class codigosastring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TasaIVAs", "Codigo", c => c.String());
            AlterColumn("dbo.SituacionIVAs", "Codigo", c => c.String());
            AlterColumn("dbo.TipoComprobanteVentas", "Codigo", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoComprobanteVentas", "Codigo", c => c.Long(nullable: false));
            AlterColumn("dbo.SituacionIVAs", "Codigo", c => c.Long(nullable: false));
            AlterColumn("dbo.TasaIVAs", "Codigo", c => c.Long(nullable: false));
        }
    }
}
