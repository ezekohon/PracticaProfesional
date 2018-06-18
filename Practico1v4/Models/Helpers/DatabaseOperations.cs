using Practico1v4.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models.Helpers
{
	class DatabaseOperations
	{
		public static void MigrateDatabase(VentasDBContext context)
		{
			//context.Database.Create();
			//var datab = context.Database;

			var newDbConnString = "data source=DESKTOP-JSIT42C\\SQLEXPRESS; initial catalog=prueba; integrated security=SSPI";//context.Database.Connection.ConnectionString;
			var connStringBuilder = new SqlConnectionStringBuilder(newDbConnString);
			//var newDbName = connStringBuilder.InitialCatalog;

			//connStringBuilder.InitialCatalog = "prueba";

			ConfigurationVentas config = new ConfigurationVentas();
			DbMigrator migrator = new DbMigrator(config);

			VentasDBContext ctx = new VentasDBContext();
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
}
