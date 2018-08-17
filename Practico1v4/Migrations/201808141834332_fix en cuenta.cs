namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixencuenta : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cuentas", "CodigoPadre", c => c.Int(nullable: false));
            DropColumn("dbo.Cuentas", "IdPadre");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cuentas", "IdPadre", c => c.Int(nullable: false));
            DropColumn("dbo.Cuentas", "CodigoPadre");
        }
    }
}
