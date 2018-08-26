namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fechainsertado : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DiarioMayors", "FechaInsertado", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.DiarioMayors", "FechaInsertado");
        }
    }
}
