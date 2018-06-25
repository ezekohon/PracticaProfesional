namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class probando : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PuntoDeVentas", "dummy");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PuntoDeVentas", "dummy", c => c.String());
        }
    }
}
