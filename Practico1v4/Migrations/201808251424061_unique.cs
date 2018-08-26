namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.DiarioMayors", new[] { "NumeroAsiento", "NumeroRenglon" }, unique: true, name: "IX_AsientoRenglon");
        }
        
        public override void Down()
        {
            DropIndex("dbo.DiarioMayors", "IX_AsientoRenglon");
        }
    }
}
