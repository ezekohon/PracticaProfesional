namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tipocomprobante : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComprobantePorSituacions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Codigo = c.String(),
                        SituacionIVAId = c.Int(nullable: false),
                        TipoComprobante = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SituacionIVAs", t => t.SituacionIVAId, cascadeDelete: true)
                .Index(t => t.SituacionIVAId);
            
            AddColumn("dbo.TipoComprobanteVentas", "Tipo", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ComprobantePorSituacions", "SituacionIVAId", "dbo.SituacionIVAs");
            DropIndex("dbo.ComprobantePorSituacions", new[] { "SituacionIVAId" });
            DropColumn("dbo.TipoComprobanteVentas", "Tipo");
            DropTable("dbo.ComprobantePorSituacions");
        }
    }
}
