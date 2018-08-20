using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class UltimoDiario
	{
		public int Id { get; set; }
		public DateTime UltimaFechaImpresion { get; set; }
		public int UltimoNumeroFolio { get; set; }
		public int UltimoNumeroAsiento { get; set; }
		public int UltimoNumeroRenglon { get; set; }
		public int UltimoNumeroTransporte { get; set; }
	}
}
