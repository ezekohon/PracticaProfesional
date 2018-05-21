using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
    [Table("Roles")]
    class Rol
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Privilegio { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
