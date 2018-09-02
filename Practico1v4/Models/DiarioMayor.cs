using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class DiarioMayor
	{
		[Key]
		public int Id { get; set; }//C:\Users\Ezequiel\Google Drive\Juan 23\Practica Profesional\Practico1v4\Practico1v4\Models\DiarioMayor.cs

		public DateTime FechaContabilidad { get; set; }

		[Index("IX_AsientoRenglon", 1, IsUnique = true)]
		public int NumeroAsiento { get; set; }
		[Index("IX_AsientoRenglon", 2, IsUnique = true)]
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



		[NotMapped]
		public string TipoAsiento {
			get 
			{
				return this.Tipo.ToString();
			}
		}


		public enumRegistrado Registrado { get; set; } //0/5/9
		public enumTipo Tipo { get; set; } //apertura, normal, cierre ENUM??

		public DateTime FechaInsertado { get; set; }


	}

	//public enum enumokCarga
	//{
	//	Mal = 0,
	//	OK = 1
	//}

	//public enum enumDebeHaber
	//{
	//	Debe = 0,
	//	Haber = 1
	//}

	//public enum enumRegistrado
	//{
	//	NoRegistrado = 0,
	//	Parcial = 5,
	//	Registrado = 9
	//}

	//public enum enumTipo
	//{
	//	Apertura = 0,
	//	Normal = 1,
	//	Cierre = 2
	//}
}
