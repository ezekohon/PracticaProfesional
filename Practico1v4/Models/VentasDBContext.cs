using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace Practico1v4.Models
{
    class VentasDBContext : DbContext
    {
        public DbSet<PuntoDeVenta> PuntosDeVenta { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }


		//static VentasDBContext()
		//{
		//	AuditManager.DefaultConfiguration.AutoSavePreAction = (context, audit) =>
		//	   // ADD "Where(x => x.AuditEntryID == 0)" to allow multiple SaveChanges with same Audit
		//	   (context as VentasDBContext).AuditEntries.AddRange(audit.Entries);
		//}
		public override int SaveChanges()
		{
			var audit = new Audit();
			audit.PreSaveChanges(this);
			var rowAffecteds = base.SaveChanges();
			audit.PostSaveChanges();

			if (audit.Configuration.AutoSavePreAction != null)
			{
				audit.Configuration.AutoSavePreAction(this, audit);
				base.SaveChanges();
			}

			return rowAffecteds;
		}
	}
}
