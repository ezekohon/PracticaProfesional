using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Helpers
{
	public class SetupPermisosHelper
	{
		private static SetupPermisosHelper sInstance;

		public static SetupPermisosHelper instance {
			get {
				if ((sInstance == null))
				{
					sInstance = new SetupPermisosHelper();
				}

				return sInstance;
			}
		}

		private SetupPermisosHelper()
		{
		}

		public void setupMenuPorOperacion(Control tool, Common.UsuarioData.operaciones operacion)
		{
			if (!Common.UsuarioData.usuarioTieneAccesoOperacion(operacion))
			{
				tool.Enabled = false;
			}
		}

		public void setupMenuPorOperacion(ToolStripMenuItem tool, Common.UsuarioData.operaciones operacion)
		{
			if (!Common.UsuarioData.usuarioTieneAccesoOperacion(operacion))
			{
				tool.Enabled = false;
			}
		}

		//public void setupMenuPorRol(ToolStripMenuItem tool, SOI_Usuarios.Usuario.GruposEnum grupo)
		//{
		//	if (!SOI_UI_COMMON.AppManager.GetAppManager().usuario.AccesoGrupo(grupo))
		//	{
		//		tool.Enabled = false;
		//	}
		//}

	}
}
