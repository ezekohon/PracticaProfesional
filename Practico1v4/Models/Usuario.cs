using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
    class Usuario
    {
		public int Id { get; set; }
		[Required]
		[Index(IsUnique = true)]
		[StringLength(200)]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }

		[Required]
		public int RolId { get; set; }
		[Required]
		public Rol Rol { get; set; }


	}
}
