using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class ComprobanteEncabezadoPie
	{
		public int Id { get; set; }

		public int TenantId { get; set; } //empresa
		public Tenant Tenant { get; set; }

		public int ClienteId { get; set; }
		public Cliente Cliente { get; set; }

		public DateTime FechaEmision { get; set; }

		public int TiposComprobantesVentaId { get; set; }
		public TipoComprobanteVenta TiposComprobantesVenta { get; set; }

		//punto de venta??

		public long NumeroComprobante { get; set; }

		//PIE

		public decimal Neto21 { get; set; }
		public decimal IVA21 { get; set; }
		public decimal Neto27 { get; set; }
		public decimal IVA27 { get; set; }
		public decimal Exento { get; set; }
		public decimal NoGravado { get; set; }
		public decimal IVARNI { get; set; }
		public decimal Retenciones { get; set; }

		public decimal Total { get; set; }
	}
}
