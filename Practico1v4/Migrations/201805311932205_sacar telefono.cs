namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sacartelefono : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuarios", "Telefono");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuarios", "Telefono", c => c.Long(nullable: false));
        }
    }
}
