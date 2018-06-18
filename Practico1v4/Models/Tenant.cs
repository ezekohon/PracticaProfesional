using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class Tenant
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Host { get; set; }
		public string BaseDeDatos { get; set; }
		public string ConnectionString { get; set; }
	}
}
