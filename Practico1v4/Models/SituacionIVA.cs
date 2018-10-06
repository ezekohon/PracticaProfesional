using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class SituacionIVA
	{
		public int Id { get; set; }
		public string Codigo { get; set; }
		public string Descripcion { get; set; }
		public string Sigla { get; set; }

		public override string ToString()
		{
			return Descripcion;
		}
	}
}
