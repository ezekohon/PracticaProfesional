namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dropcolumnasdevendedores : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Vendedores", "Direccion");
            DropColumn("dbo.Vendedores", "Ciudad");
            DropColumn("dbo.Vendedores", "Telefono");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Vendedores", "Telefono", c => c.Long(nullable: false));
            AddColumn("dbo.Vendedores", "Ciudad", c => c.String());
            AddColumn("dbo.Vendedores", "Direccion", c => c.String());
        }
    }
}
