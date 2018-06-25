namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class probando1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PuntoDeVentas", "dummy", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PuntoDeVentas", "dummy");
        }
    }
}
