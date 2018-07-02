using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Views.Backup
{
	public partial class BackupFrm : Form
	{
		public BackupFrm()
		{
			InitializeComponent();
		}

		private void BackupFrm_Load(object sender, EventArgs e)
		{

		}

		SqlConnection con = new SqlConnection(Common.TenantData.tenant.ConnectionString);

		private void buttonBuscar1_Click(object sender, EventArgs e)
		{
			
		}

		private void buttonBackup_Click(object sender, EventArgs e)
		{
			string database = con.Database.ToString();
			try
			{
				var folder = Path.Combine("C:/Users/Ezequiel/Desktop/BACKUPS/");
				var fullpath = Path.Combine(folder, Common.TenantData.tenant.BaseDeDatos);
				System.IO.Directory.CreateDirectory(fullpath);

				string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + textBoxBackup.Text + "\\" + Common.TenantData.tenant.BaseDeDatos + "-" + DateTime.Now.ToString("yyyy-MM-dd-(HH-mm-ss)") + ".bak'";

				using (SqlCommand command = new SqlCommand(cmd, con))
				{
					if (con.State != ConnectionState.Open)
					{
						con.Open();
					}

					command.ExecuteNonQuery();
					con.Close();
					Helpers.CreadorMensajes.mensajeObservacion("Copia de seguridad realizada con éxito.");
					//buttonBackup.Enabled = false;
				}
				
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

		private void buttonRestaurar_Click(object sender, EventArgs e)
		{
			string database = Common.TenantData.tenant.BaseDeDatos;//con.Database.ToString();
			if (con.State != ConnectionState.Open)
			{
				con.Open();
			}
			try
			{
				var path = Path.Combine("C:/Users/Ezequiel/Desktop/BACKUPS/", Common.TenantData.tenant.BaseDeDatos);
				var directory = new DirectoryInfo(path);
				var archivo = directory.GetFiles().OrderByDescending(f => f.LastWriteTime).First().ToString();
				var pathArchivo = path + "/" + archivo;

				if (archivo != null)
				{
					string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
					SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
					bu2.ExecuteNonQuery();

					string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + pathArchivo + "'WITH REPLACE;";
					SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
					bu3.ExecuteNonQuery();

					

					Helpers.CreadorMensajes.mensajeObservacion("Restauración realizada con éxito.");
					
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
				SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
				bu4.ExecuteNonQuery();

				con.Close();
			}
		}

		private void buttonBuscarRestaurar_Click(object sender, EventArgs e)
		{
			var path = Path.Combine("C:/Users/Ezequiel/Desktop/BACKUPS/", Common.TenantData.tenant.BaseDeDatos);
			
			OpenFileDialog dlg = new OpenFileDialog();
			dlg.InitialDirectory = @"C:\Users\Ezequiel\Desktop\BACKUPS\" + Common.TenantData.tenant.BaseDeDatos;
			dlg.Filter = "SQL SERVER database backup files|*.bak";
			dlg.Title = "Resgauración de base de datos";
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				textBoxRestauracion.Text = dlg.FileName;
				buttonRestaurarElegir.Enabled = true;
			}
		}

		private void buttonRestaurarElegir_Click(object sender, EventArgs e)
		{
			string database = Common.TenantData.tenant.BaseDeDatos;//con.Database.ToString();
			ConfirmacionRestauracion frm = new ConfirmacionRestauracion();
			if (frm.ShowDialog(this) == DialogResult.Yes)
			{
				if (con.State != ConnectionState.Open)
				{
					con.Open();
				}
				try
				{

					if (!string.IsNullOrWhiteSpace(textBoxRestauracion.Text) && textBoxRestauracion.Text.Contains(database))
					{
						string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
						SqlCommand bu2 = new SqlCommand(sqlStmt2, con);
						bu2.ExecuteNonQuery();

						string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBoxRestauracion.Text + "'WITH REPLACE;";
						SqlCommand bu3 = new SqlCommand(sqlStmt3, con);
						bu3.ExecuteNonQuery();

						//string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
						//SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
						//bu4.ExecuteNonQuery();

						Helpers.CreadorMensajes.mensajeObservacion("Restauración realizada con éxito.");
						//con.Close();
					}
					else
						Helpers.CreadorMensajes.mensajeError("No es una copia de seguridad de la base de datos que está queriendo restaurar!");
				}
				catch (Exception ex)
				{
					Helpers.CreadorMensajes.mensajeError("No es una copia de seguridad de la base de datos que está queriendo restaurar!");

					//throw ex;
				}
				finally
				{
					string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
					SqlCommand bu4 = new SqlCommand(sqlStmt4, con);
					bu4.ExecuteNonQuery();

					con.Close();
				}
			}
		}

		private void buttonBuscar_Click(object sender, EventArgs e)
		{
			var path = Path.Combine("C:/Users/Ezequiel/Desktop/BACKUPS/", Common.TenantData.tenant.BaseDeDatos);
			FolderBrowserDialog dlg = new FolderBrowserDialog();
			dlg.SelectedPath = @"C:\Users\Ezequiel\Desktop\BACKUPS\" + Common.TenantData.tenant.BaseDeDatos;
			if (dlg.ShowDialog() == DialogResult.OK)
			{
				textBoxBackup.Text = dlg.SelectedPath;
				buttonBackup.Enabled = true;
			}
		}
	}
}
