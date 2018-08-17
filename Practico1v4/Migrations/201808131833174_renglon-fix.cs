namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renglonfix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Renglones", "Sucursal");
            DropColumn("dbo.Renglones", "Seccion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Renglones", "Seccion", c => c.Int(nullable: false));
            AddColumn("dbo.Renglones", "Sucursal", c => c.String());
        }
    }
}
