namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populartablas : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PuntoDeVentas (Descripcion) VALUES ('Bahia Blanca')");
            Sql("INSERT INTO PuntoDeVentas (Descripcion) VALUES ('Olavarria')");
            Sql("INSERT INTO PuntoDeVentas (Descripcion) VALUES ('Azul')");
           
        }
        
        public override void Down()
        {
        }
    }
}
