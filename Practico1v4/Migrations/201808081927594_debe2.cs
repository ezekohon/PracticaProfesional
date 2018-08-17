namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class debe2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Renglones", "Debe", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Renglones", "Haber", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Renglones", "Haber");
            DropColumn("dbo.Renglones", "Debe");
        }
    }
}
