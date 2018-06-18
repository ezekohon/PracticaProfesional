using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models.Helpers
{
	public static class DBFactory
	{
		public static Tenant _tenant;

		//public static DBFactory(Tenant tenant)
		//{

		//}

		public static DbContext GetContext(string dbNombre)
		{
			
			return new VentasDBContext(connectionStringBuilder(dbNombre));
		}

		public static string connectionStringBuilder(string dbNombre)//, string datasource)
		{
			return "data source=DESKTOP-JSIT42C\\SQLEXPRESS; initial catalog=" + dbNombre + "; integrated security=SSPI";
		}
	}
}
