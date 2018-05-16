using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Models
{
    class VentasDBContext : DbContext
    {
        public DbSet<PuntoDeVenta> PuntosDeVenta { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        /*agregar la clase*/
    }
}
