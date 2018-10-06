using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class Articulo
	{
		public int Id { get; set; }
		public long Codigo { get; set; }
		public string Descripcion { get; set; }

		public long CantidadEnExistencia { get; set; }
		public decimal CostoUnitario { get; set; }
		public decimal PrecioNetoVenta { get; set; }

		public int TasaIVAId { get; set; }
		public TasaIVA TasaIVA { get; set; }

		

		public enumImpuestoInterno TipoImpuestoInterno { get; set; }
		public decimal ValorImpuestoInterno { get; set; }

	}

	public enum enumImpuestoInterno
	{
		Cantidad = 0,
		Porcentaje = 1
	}
}
