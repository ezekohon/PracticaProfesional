namespace Practico1v4.MigrationsTenants
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class ConfigurationTenants : DbMigrationsConfiguration<Practico1v4.Models.TenantsDBContext>
    {
        public ConfigurationTenants()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Practico1v4.Models.TenantsDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
