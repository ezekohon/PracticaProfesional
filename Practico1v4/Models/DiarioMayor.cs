using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class DiarioMayor
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
		
		public Renglon.enumRegistrado Registrado { get; set; } //0/5/9
		public Renglon.enumTipo Tipo { get; set; } //apertura, normal, cierre ENUM??


	}
}
