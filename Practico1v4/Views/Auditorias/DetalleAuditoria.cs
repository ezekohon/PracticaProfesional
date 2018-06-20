using Practico1v4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Views.Auditorias
{
	public partial class DetalleAuditoria : Form
	{
		public DetalleAuditoria()
		{
			InitializeComponent();
		}

		public int IdEntry { get; set; }

		private void DetalleAuditoria_Load(object sender, EventArgs e)
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				dataGridView1.DataSource = context.AuditEntryProperties.Where(x => x.AuditEntryID == IdEntry).ToList();
				
				//var audit = new Audit();
				//var entries = audit.Entries;
			}
		}
	}
}
