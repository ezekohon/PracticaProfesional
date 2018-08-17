using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	[Table("Renglones")]
	public class Renglon //es en realidad asientos
	{
		[Key]
		public int Id { get; set; }

		public DateTime FechaContabilidad { get; set; }
		public int NumeroAsiento { get; set; }
										  
		public int NumeroRenglon { get; set; }

		public int IdCuenta { get; set; }
		public Cuenta Cuenta { get; set; }

		public DateTime FechaVencimiento { get; set; }
		public DateTime FechaOperacion { get; set; }
		public string Comprobante { get; set; }
		//public string Sucursal { get; set; }
		//public int Seccion { get; set; }
		//public enumDebeHaber esDebeHaber { get; set; } //0/1
		//public Decimal Importe { get; set; }
		public Decimal Debe { get; set; }
		public Decimal Haber { get; set; }
		public string Leyenda { get; set; }
		public enumokCarga OK_Carga { get; set; } // 0/1
		public enumRegistrado Registrado { get; set; } //0/5/9
		public enumTipo Tipo { get; set; } //apertura, normal, cierre ENUM??

		public enum enumokCarga
		{
			Mal = 0,
			Bein = 1
		}

		public enum enumDebeHaber
		{
			Debe = 0,
			Haber = 1
		}

		public enum enumRegistrado
		{
			NoRegistrado = 0,
			Parcial = 5,
			Registrado = 9
		}

		public enum enumTipo
		{
			Apertura = 0,
			Normal = 1,
			Cierre = 2
		}


	}
}
