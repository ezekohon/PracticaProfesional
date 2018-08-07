using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class Tenant
	{
		public int Id { get; set; }
		public string Nombre { get; set; }
		public string Host { get; set; }
		public string BaseDeDatos { get; set; }
		public string ConnectionString { get; set; }
		public DateTime FechaInicioEjercicioContable { get; set; }
		public DateTime FechaCierreEjercicioContable { get; set; }
		public DateTime FechaImpresionUltimoDiario { get; set; }
		public long CUIT { get; set; }
		public string RazonSocial { get; set; }
		public string SituacionFrenteAIVA { get; set; } //enum?
		public string  DireccionFisica { get; set; }
	}
}
