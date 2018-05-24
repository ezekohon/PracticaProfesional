using Practico1v4.Views.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico1v4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.ThreadException += Application_ThreadException;
			DialogResult result;
			using (var loginForm = new Lanzador())
				result = loginForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				// login was successful
				Application.Run(new MainForm());
			}

			//Application.Run(new Lanzador());
        }

		private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			throw new Exception(e.Exception.Message);
		}
	}
}
