using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class ComprobanteRenglon
	{
		public int Id { get; set; }

		public int ComprobanteEncabezadoPieId { get; set; }
		public ComprobanteEncabezadoPie ComprobanteEncabezadoPie { get; set; }

		public int ArticuloId { get; set; }
		public Articulo Articulo { get; set; }

		public int Cantidad { get; set; }

		public decimal Importe { get; set; }
	}
}
