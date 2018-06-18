using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	class TenantsDBContext : DbContext
	{
		public DbSet<Tenant> Tenants { get; set; }

		//public Tenant getTenant(string dbName)
		//{
		//	var tenant = Tenants.FirstOrDefault(t => t.BaseDeDatos == dbName);
		//	return tenant;
		//}
	}
}
