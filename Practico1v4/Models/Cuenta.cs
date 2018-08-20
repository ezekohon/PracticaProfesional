using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
		//[Index(IsUnique = true)]
		public string CodigoBalance { get; set; }
		public string CodigoPadre { get; set; }

		public override string ToString()
		{
			return Nombre;
		}
	}
}
