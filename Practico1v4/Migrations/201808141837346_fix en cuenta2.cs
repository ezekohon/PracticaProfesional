namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixencuenta2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cuentas", "CodigoPadre", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cuentas", "CodigoPadre", c => c.Int(nullable: false));
        }
    }
}
