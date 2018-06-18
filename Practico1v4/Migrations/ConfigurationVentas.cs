namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationVentas : DbMigrationsConfiguration<Practico1v4.Models.VentasDBContext>
    {
        public ConfigurationVentas()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Practico1v4.Models.VentasDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
