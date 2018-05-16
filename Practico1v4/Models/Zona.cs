using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practico1v4.Models
{
    class Zona
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }


        public ICollection<Vendedor> Vendedores { get; set; }
    }
}
