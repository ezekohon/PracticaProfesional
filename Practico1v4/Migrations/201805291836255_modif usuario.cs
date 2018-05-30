namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifusuario : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "Telefono", c => c.Long(nullable: false));
            AddColumn("dbo.Usuarios", "Mail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "Mail");
            DropColumn("dbo.Usuarios", "Telefono");
        }
    }
}
