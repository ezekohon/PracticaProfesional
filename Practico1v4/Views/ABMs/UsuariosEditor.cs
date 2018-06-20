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

namespace Practico1v4.Views.ABMs
{
	public partial class UsuariosEditor : Form
	{
		public UsuariosEditor()
		{
			InitializeComponent();
		}

		private void UsuariosEditor_Load(object sender, EventArgs e)
		{
			toolStripStatusLabel1.Text = (currentStatus == status.insertar) ? "Modo insertar" : "Modo editar";
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				
				comboBoxRol.ValueMember = "Id";
				comboBoxRol.DisplayMember = "Nombre";
				comboBoxRol.DataSource = context.Roles.ToList();
				comboBoxRol.SelectedIndex = -1;
			}
			if (currentStatus == status.editar)
			{
				textBoxPassword.Enabled = false;
				checkBoxShowPassword.Enabled = false;
				cargarDatos();
			}
		}

		public Usuario usuario { get; set; }

		public enum status
		{
			ninguno = 0,
			insertar = 1,
			editar = 2
		}

		private status _currentStatus;

		public status currentStatus {
			get { return _currentStatus; }
			set { _currentStatus = value; }
		}

		internal void cargarDatos() 
		{
			textBoxUsuario.Text = usuario.Username;
			comboBoxRol.SelectedValue = usuario.Rol.Id;
		}

		private void buttonLimpiar_Click(object sender, EventArgs e)
		{
			limpiarCampos();
		}

		private void limpiarCampos()
		{
			textBoxUsuario.Clear();
			comboBoxRol.SelectedIndex = -1;
			textBoxPassword.Clear();
		}

		private void buttonConfirmar_Click(object sender, EventArgs e)
		{
			if (validarCampos())
			{
				if (currentStatus == status.insertar)
					insertar();
				else if (currentStatus == status.editar)
					editar();
			}
		}

		public bool validarCampos()
		{
			bool puedoInsertar = true;
			if (string.IsNullOrWhiteSpace(textBoxUsuario.Text))
			{
				errorProviderUsuario.SetError(textBoxUsuario, "Requerido");
				errorProviderUsuario.BlinkStyle = ErrorBlinkStyle.NeverBlink;
				puedoInsertar = false;
			}
			else { errorProviderUsuario.Clear(); }

			if (currentStatus != status.editar)
			{
				if (string.IsNullOrWhiteSpace(textBoxPassword.Text))
				{
					errorProviderPassword.SetError(textBoxPassword, "Requerido");
					errorProviderPassword.BlinkStyle = ErrorBlinkStyle.NeverBlink;
					puedoInsertar = false;
				}
				else { errorProviderPassword.Clear(); }
			}

			if (comboBoxRol.SelectedIndex == -1)
			{
				errorProviderRol.SetError(comboBoxRol, "Requerido");
				errorProviderRol.BlinkStyle = ErrorBlinkStyle.NeverBlink;
				puedoInsertar = false;
			}
			else { errorProviderRol.Clear(); }

			return puedoInsertar;
		}

		public void insertar()
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				Usuario u = new Usuario();
				Rol rol = (Rol)comboBoxRol.SelectedItem;
				u.Username = textBoxUsuario.Text;
				u.RolId = rol.Id;
				u.Rol = rol;

				u.Password = Helpers.SecurePasswordHasher.Hash(textBoxPassword.Text);
				context.Usuarios.Add(u);
				context.Roles.Attach(rol);
				try
				{
					context.SaveChanges();
					DialogResult = DialogResult.OK;
				}
				catch (Exception ex)
				{
					throw;
				}
			}
		}

		private void editar()
		{
			using (var context = new VentasDBContext(Common.TenantData.tenant.ConnectionString))
			{
				//Usuario u = new Usuario();
				Rol rol = (Rol)comboBoxRol.SelectedItem;
				
				usuario.Username = textBoxUsuario.Text;
				usuario.RolId = rol.Id;
				usuario.Rol = rol;
				//u.Password = Helpers.SecurePasswordHasher.Hash(textBoxPassword.Text);
				var entry = context.Usuarios.Find(usuario.Id);
				context.Entry(entry).CurrentValues.SetValues(usuario);
				try
				{
					context.SaveChanges();
					DialogResult = DialogResult.OK;
				}
				catch (Exception ex)
				{
					throw;
				}
			}
		}

		private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
		{
			textBoxPassword.UseSystemPasswordChar = !checkBoxShowPassword.Checked;
		}

		private void textBoxUsuario_Validating(object sender, CancelEventArgs e)
		{

		}
	}
}
