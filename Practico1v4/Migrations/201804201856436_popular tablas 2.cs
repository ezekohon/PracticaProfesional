namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populartablas2 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Vendedores (Nombre, Apellido, Direccion, Ciudad, Telefono, PuntoDeVenta_Id) Values ('Mario', 'Santos', 'Drago 221','Olavarria', 154788232, 7)");
            Sql("INSERT INTO Vendedores (Nombre, Apellido, Direccion, Ciudad, Telefono, PuntoDeVenta_Id) Values ('Pablo', 'Lamponne', 'Saavedra 3221', 'Azul', 156587900, 9)");
            Sql("INSERT INTO Vendedores (Nombre, Apellido, Direccion, Ciudad, Telefono, PuntoDeVenta_Id) Values ('Emilio', 'Ravenna', 'Mitre 988','Bahia Blanca', 15321074, 8)");
            Sql("INSERT INTO Vendedores (Nombre, Apellido, Direccion, Ciudad, Telefono, PuntoDeVenta_Id) Values ('Gabriel', 'Medina', 'Colon 434','Olavarria', 157842691, 7)");
        }
        
        public override void Down()
        {
        }
    }
}
