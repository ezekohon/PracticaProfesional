namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cuentanonulleable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cuentas", "IdPadre", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Cuentas", "IdPadre", c => c.Int());
        }
    }
}
