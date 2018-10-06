using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class ComprobantePorSituacion
	{
		public int Id { get; set; }
		public string Codigo { get; set; }

		public int SituacionIVAId { get; set; }
		public SituacionIVA SituacionIVA { get; set; }

		public TipoComprobante TipoComprobante { get; set; }
	}

	public enum TipoComprobante
	{
		A = 0,
		B = 1,
		C = 2

	}
}
