using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Z.EntityFramework.Plus;

namespace Practico1v4.Models
{
    class VentasDBContext : DbContext
    {
		//private static Tenant _tenant;

		//public Tenant tenant { get; set; }

		public DbSet<PuntoDeVenta> PuntosDeVenta { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Zona> Zonas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Rol> Roles { get; set; }
		public DbSet<Operacion> Operaciones { get; set; }
		public DbSet<AuditEntry> AuditEntries { get; set; }
		public DbSet<AuditEntryProperty> AuditEntryProperties { get; set; }
		public DbSet<Cuenta> Cuentas { get; set; }
		public DbSet<Renglon> Renglones { get; set; }
		public DbSet<UltimoDiario> UltimoDiario { get; set; }
		public DbSet<DiarioMayor> DiarioMayor { get; set; }
		public DbSet<tempBalance> tempBalance { get; set; }

		public VentasDBContext() //es static, no public
		{
			AuditManager.DefaultConfiguration.AutoSavePreAction = (context, audit) =>
			   // ADD "Where(x => x.AuditEntryID == 0)" to allow multiple SaveChanges with same Audit
			   (context as VentasDBContext).AuditEntries.AddRange(audit.Entries);
			//AuditManager.DefaultConfiguration.IgnorePropertyUnchanged = false;
		}


		public VentasDBContext(string connectionString) : base(connectionString)//Common.TenantData.tenant.ConnectionString)
		{
			AuditManager.DefaultConfiguration.AutoSavePreAction = (context, audit) =>
			   // ADD "Where(x => x.AuditEntryID == 0)" to allow multiple SaveChanges with same Audit
			   (context as VentasDBContext).AuditEntries.AddRange(audit.Entries);
			//AuditManager.DefaultConfiguration.IgnorePropertyUnchanged = false;


			//var migrationConfig = new MigrationConf();
			//var migrator = new DbMigrator(migrationConfig);
			//migrationConfig.TargetDatabase = new System.Data.Entity.Infrastructure.DbConnectionInfo(connectionString);
			//migrator.Configuration.TargetDatabase = new System.Data.Entity.Infrastructure.DbConnectionInfo(connectionString);
			//var migrations = migrator.GetPendingMigrations();
			//var already = migrator.GetDatabaseMigrations();
			//foreach (string s in migrator.GetPendingMigrations())//GetPendingMigrations())
			//{
			//	//Act
			//	Console.WriteLine("Applying migration {0}", s);
			//	Action act = () => migrator.Update(s);

			//	//Assert
			//	//act.ShouldNotThrow();
			//}

			//Database.SetInitializer<VentasDBContext>(
			//	new MigrateDatabaseToLatestVersion<
			//		VentasDBContext, MigrationConf>(true, migrationConfig));


		}

		//static VentasDBContext()
		//{
		//	AuditManager.DefaultConfiguration.AutoSavePreAction = (context, audit) =>
		//	   // ADD "Where(x => x.AuditEntryID == 0)" to allow multiple SaveChanges with same Audit
		//	   (context as VentasDBContext).AuditEntries.AddRange(audit.Entries);
		//	//AuditManager.DefaultConfiguration.IgnorePropertyUnchanged = false;
		//}
		public override int SaveChanges()
		{
			
			var audit = new Audit();
			var usu = (Common.UsuarioData.usuario != null) ? Common.UsuarioData.usuario.Username.ToString() : " ";
			audit.CreatedBy = usu +"("+ System.Environment.MachineName +")"; //concatenar el nombre de la terminal aca
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

	sealed class MigrationConf : DbMigrationsConfiguration<VentasDBContext>
	{
		public MigrationConf()
			: base()
		{
			AutomaticMigrationsEnabled = false;
			AutomaticMigrationDataLossAllowed = true;

			
			
		}
	}
}
