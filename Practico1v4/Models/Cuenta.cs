using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class Cuenta
	{
		public int Id { get; set; }
		public int Tipo { get; set; }
		public string Nombre { get; set; }
		public string CodigoBalance { get; set; }
		public string CodigoPadre { get; set; }
	}
}
