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

namespace Practico1v4.Views
{
	public partial class BaseForm : Form
	{
		public BaseForm()
		{
			InitializeComponent();
		}

		public event EventHandler UserIsAllowed;
		public event EventHandler UserIsDenied;

		private Usuario usuario;
		private List<string> formRoles;

		public List<string> ValidatedUserRoles { get; private set; }
		
		public bool UserCanOpenForm { get; private set; }

		//todo poner los roles permitidos en el form al crearlo?
		private void BaseForm_Load(object sender, EventArgs e)
		{

		}

		public BaseForm(string[] roles, Usuario usuarioLogueado)
		{
				this.ValidatedUserRoles = new List<string>();
				this.formRoles = new List<string>();
				this.formRoles.AddRange(roles);

				this.usuario = usuarioLogueado;

				ValidateUserRoles();
			

			InitializeComponent();
		}

		private void ValidateUserRoles()
		{
			this.UserCanOpenForm = formRoles.Contains(usuario.Rol.Nombre);
		}

		public new DialogResult ShowDialog(IWin32Window owner)
		{
			DialogResult result = DialogResult.None;
			if (UserCanOpenForm)
			{
				result = base.ShowDialog(owner);//ShowForm(calledShowMethod, owner);
				if (UserIsAllowed != null)
					UserIsAllowed(this, new EventArgs());
				
			}
			else
			{
				if (UserIsDenied != null)
				{
					result = base.ShowDialog(owner);//ShowForm(calledShowMethod, owner);
					UserIsDenied(this, new EventArgs());
					
				}
				else
					return DialogResult.Cancel;
			}
			return result;
		}
	}
}
