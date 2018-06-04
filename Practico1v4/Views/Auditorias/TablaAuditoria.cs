using Practico1v4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.EntityFramework.Plus;

namespace Practico1v4.Views.Auditorias
{
	public partial class TablaAuditoria : Form
	{
		public TablaAuditoria()
		{
			InitializeComponent();
		}

		public AuditEntry entry { get; set; }



		public string tabla {
			get { return entry.EntitySetName; }
		}


		private void TablaAuditoria_Load(object sender, EventArgs e)
		{
			cargarTabla();
			labelNombreTabla.Text = "Auditando tabla: " + tabla;
		}

		private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.Value != null)
			{
				switch (e.Value.ToString())
				{
					case "EntityModified":
						e.Value = "Modificado";
						break;
					case "EntityAdded":
						e.Value = "Insertado";
						break;
					case "EntityDeleted":
						e.Value = "Eliminado";
						break;
				}
			}
		}

		private void textBoxId_TextChanged(object sender, EventArgs e)
		{
			string filtro = textBoxId.Text;
			using (var context = new VentasDBContext())
			{
				//agarrar todos los AuditEntryID que su NewValue == filtro, distinct
				//traer todas las entradas que tengan alguno de esos AuditEntryID
				var q1 = (from p in context.AuditEntryProperties
						  join a in context.AuditEntries on p.AuditEntryID equals a.AuditEntryID
						  where a.EntitySetName == tabla && p.NewValueFormatted == filtro
						  select new
						  {
							  AuditEntryID = p.AuditEntryID
						  }).Distinct();

				var query = (from p in context.AuditEntryProperties
							 join a in context.AuditEntries on p.AuditEntryID equals a.AuditEntryID
							 where a.EntitySetName == tabla && q1.Any(x => x.AuditEntryID.Equals(p.AuditEntryID))//q1.Any(x => x.AuditEntryID == p.AuditEntryID)
							 select new
							 {
								 IdAuditoria = p.AuditEntryID,
								 Campo = p.PropertyName,
								 Valor_nuevo = p.NewValueFormatted,
								 Valor_viejo = p.OldValueFormatted,
								 Fecha = a.CreatedDate,
								 Creador = a.CreatedBy,
								 Estado = a.State
							 }).OrderByDescending(x => x.Fecha);

				if (string.IsNullOrWhiteSpace(filtro))
					cargarTabla();
				else
					dataGridView1.DataSource = query.ToList();
			}


		}
		private void cargarTabla()
		{
			using (var context = new VentasDBContext())
			{
				//dataGridView1.DataSource = context.AuditEntryProperties.Where(x => x.Parent.EntitySetName == entry.EntitySetName).ToList();
				//hacer query
				var query = from p in context.AuditEntryProperties
							join a in context.AuditEntries on p.AuditEntryID equals a.AuditEntryID
							where a.EntitySetName == tabla
							orderby a.CreatedDate descending
							select new
							{
								IdAuditoria = p.AuditEntryID,
								Campo = p.PropertyName,
								Valor_nuevo = p.NewValueFormatted,
								Valor_viejo = p.OldValueFormatted,
								Fecha = a.CreatedDate,
								Creador = a.CreatedBy,
								Estado = a.State
							};
				dataGridView1.DataSource = query.ToList();
			}
		}

		private void textBoxCreador_TextChanged(object sender, EventArgs e)
		{
			string filtro = textBoxCreador.Text;
			using (var context = new VentasDBContext())
			{
				var q1 = (from p in context.AuditEntryProperties
						  join a in context.AuditEntries on p.AuditEntryID equals a.AuditEntryID
						  where a.EntitySetName == tabla && a.CreatedBy.Contains(filtro)
						  select new
						  {
							  AuditEntryID = p.AuditEntryID
						  }).Distinct();

				var query = (from p in context.AuditEntryProperties
							 join a in context.AuditEntries on p.AuditEntryID equals a.AuditEntryID
							 where a.EntitySetName == tabla && q1.Any(x => x.AuditEntryID.Equals(p.AuditEntryID))//q1.Any(x => x.AuditEntryID == p.AuditEntryID)
							 select new
							 {
								 IdAuditoria = p.AuditEntryID,
								 Campo = p.PropertyName,
								 Valor_nuevo = p.NewValueFormatted,
								 Valor_viejo = p.OldValueFormatted,
								 Fecha = a.CreatedDate,
								 Creador = a.CreatedBy,
								 Estado = a.State
							 });

				if (string.IsNullOrWhiteSpace(filtro))
					cargarTabla();
				else
					dataGridView1.DataSource = query.ToList();
			}
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			string filtro = textBoxCreador.Text;
			using (var context = new VentasDBContext())
			{
				var q1 = (from p in context.AuditEntryProperties
						  join a in context.AuditEntries on p.AuditEntryID equals a.AuditEntryID
						  where a.EntitySetName == tabla && DbFunctions.TruncateTime(a.CreatedDate) == DbFunctions.TruncateTime(dateTimePicker1.Value)
						  select new
						  {
							  AuditEntryID = p.AuditEntryID
						  }).Distinct();

				var query = (from p in context.AuditEntryProperties
							 join a in context.AuditEntries on p.AuditEntryID equals a.AuditEntryID
							 where a.EntitySetName == tabla && q1.Any(x => x.AuditEntryID.Equals(p.AuditEntryID))//q1.Any(x => x.AuditEntryID == p.AuditEntryID)
							 select new
							 {
								 IdAuditoria = p.AuditEntryID,
								 Campo = p.PropertyName,
								 Valor_nuevo = p.NewValueFormatted,
								 Valor_viejo = p.OldValueFormatted,
								 Fecha = a.CreatedDate,
								 Creador = a.CreatedBy,
								 Estado = a.State
							 });

					dataGridView1.DataSource = query.ToList();
			}
		}
	}
}
