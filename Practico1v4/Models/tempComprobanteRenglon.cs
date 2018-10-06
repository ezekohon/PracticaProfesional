using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class tempComprobanteRenglon
	{
		public int Id { get; set; }

		public int tempComprobanteEncabezadoPieId { get; set; }
		public tempComprobanteEncabezadoPie tempComprobanteEncabezadoPie { get; set; }

		public int ArticuloId { get; set; }
		public Articulo Articulo { get; set; }

		public int Cantidad { get; set; }

		public decimal Importe { get; set; }

		[NotMapped]
		public string Descripcion {
			get {
				return this.Articulo.Descripcion.ToString();
			}
		}
		[NotMapped]
		public string PrecioNetoVenta {
			get {
				return this.Articulo.PrecioNetoVenta.ToString();
			}
		}
		[NotMapped]
		public string TasaIVA {
			get {
				return this.Articulo.TasaIVA.Porcentaje.ToString();
			}
		}
		[NotMapped]
		public string ImpuestosInternos {
			get {
				return this.Articulo.ValorImpuestoInterno.ToString();
			}
		}

		[NotMapped]
		public string NroArticulo {
			get {
				return this.Articulo.Codigo.ToString();
			}
		}
	}
}
