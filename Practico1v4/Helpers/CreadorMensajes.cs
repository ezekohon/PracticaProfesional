using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4.Helpers
{
	public class CreadorMensajes
	{
		public static void mensajeError(string msj)
		{
			using (new CenterWinDialog(Form.ActiveForm))
			{
				
				MessageBox.Show(msj, "Error");
			}
		}

		public static DialogResult mensajeEliminar(string objetoAEliminar)
		{
			using (new CenterWinDialog(Form.ActiveForm))
			{
				MessageBoxManager.Cancel = "Cancelar";
				DialogResult r = MessageBox.Show("Realmente desea eliminar " + objetoAEliminar + "?", "Cuidado", MessageBoxButtons.OKCancel);
				return r;
			}
		}

		public static void mensajeObservacion(string msj)
		{
			using (new CenterWinDialog(Form.ActiveForm))
			{

				MessageBox.Show(msj, "");
			}
		}
	}
}
