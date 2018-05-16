using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Practico1v4.Models
{
    [Table("Vendedores")]
    class Vendedor
    {
        public int Id { get; set; }
        [Required]
        public PuntoDeVenta PuntoDeVenta { get; set; }

        public int PuntoDeVentaId { get; set; }

        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //public string Direccion { get; set; }
        //public string Ciudad { get; set; }
        //public long Telefono { get; set; }
        [Required]
        public Zona Zona { get; set; }
        [Required]
        public int ZonaId { get; set; }
    }
}
