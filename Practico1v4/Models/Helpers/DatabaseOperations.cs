using Practico1v4.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models.Helpers
{
	class DatabaseOperations
	{
		public static void MigrateDatabase(Tenant tenant)//string DBName/*VentasDBContext ctx*/)
		{
			//context.Database.Create();
			//var datab = context.Database;
			//Tenant tenant = new Tenant();
			using (var context = new TenantsDBContext())
			{
				//tenant.BaseDeDatos = DBName;
				tenant.ConnectionString = "data source=DESKTOP-JSIT42C\\SQLEXPRESS; initial catalog=" + tenant.BaseDeDatos + "; integrated security=SSPI";
				tenant.Host = (System.Environment.MachineName == "DESKTOP-JSIT42C") ? "DESKTOP-JSIT42C\\SQLEXPRESS" : "localhost"; 
				tenant.Nombre = tenant.BaseDeDatos;
				
				context.Tenants.Add(tenant);
				context.SaveChanges();
			}
			Common.TenantData.tenant = tenant;
			var newDbConnString = "data source=DESKTOP-JSIT42C\\SQLEXPRESS; initial catalog=" + tenant.BaseDeDatos + "; integrated security=SSPI";//context.Database.Connection.ConnectionString;
			var connStringBuilder = new SqlConnectionStringBuilder(newDbConnString);
			

			connStringBuilder.InitialCatalog = tenant.BaseDeDatos;

			ConfigurationVentas config = new ConfigurationVentas();
			DbMigrator migrator = new DbMigrator(config);

			VentasDBContext ctx = new VentasDBContext(newDbConnString);
			ctx.Database.Create();

			Console.WriteLine("Past migrations:");
			foreach (string s in migrator.GetDatabaseMigrations())
				Console.WriteLine(s);

			Console.WriteLine("Local migrations:");
			foreach (string s in migrator.GetLocalMigrations())
				Console.WriteLine(s);

			Console.WriteLine("Pending migrations:");
			foreach (string s in migrator.GetPendingMigrations())
				Console.WriteLine(s);

			Console.WriteLine("Migrating...");
			foreach (string s in migrator.GetLocalMigrations())//GetPendingMigrations())
			{
				//Act
				Console.WriteLine("Applying migration {0}", s);
				Action act = () => migrator.Update(s);

				//Assert
				//act.ShouldNotThrow();
			}

		}
	}

	sealed class MigrationConf : DbMigrationsConfiguration<VentasDBContext>
	{
		public MigrationConf()
			: base()
		{
			AutomaticMigrationsEnabled = false;
			AutomaticMigrationDataLossAllowed = true;


		}
	}
}
