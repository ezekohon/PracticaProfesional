using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class tempBalance
	{
		public int Id { get; set; }
		public int Tipo { get; set; }
		public string CodigoBalance { get; set; }
		public string CodigoPadre { get; set; }
		public string Nombre { get; set; }

		public decimal SaldoInicial { get; set; }
		public decimal Debitos { get; set; }
		public decimal Creditos { get; set; }
		public decimal SaldoAcumulado { get; set; }
		public decimal SaldoCierre { get; set; }
	}
}
