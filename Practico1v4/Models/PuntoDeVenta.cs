using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
    
    class PuntoDeVenta
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
		public string dummy { get; set; }

		public ICollection<Vendedor> Vendedores { get; set; }
    }
}
