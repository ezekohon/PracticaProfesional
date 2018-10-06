using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
	public class Cliente
	{
		public int Id { get; set; }
		public string Codigo { get; set; }
		public string Nombre { get; set; }

		public string RazonSocial { get; set; }
		public string Domicilio { get; set; }
		public string CUIT { get; set; }

		[Required]
		public int SituacionIVAId { get; set; }
		[Required]
		public SituacionIVA SituacionIVA { get; set; }

		
	}
}
