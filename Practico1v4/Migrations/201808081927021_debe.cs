namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class debe : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Renglones", "esDebeHaber");
            DropColumn("dbo.Renglones", "Importe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Renglones", "Importe", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Renglones", "esDebeHaber", c => c.Int(nullable: false));
        }
    }
}
