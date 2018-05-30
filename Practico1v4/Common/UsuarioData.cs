using Practico1v4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1v4.Common
{
	internal static class UsuarioData
	{
		public static Usuario usuario;

		public enum operaciones
		{
			SUPER = 1,
			USUARIOS_CONSULTAR = 2,
			USUARIOS_MODIFICAR = 3,
			USUARIOS_ALTABAJA = 4,
			USUARIOS_SUPER = 5,
			PUNTOSDEVENTA_CONSULTAR = 6,
			PUNTOSDEVENTA_MODIFICAR = 7,
			PUNTOSDEVENTA_ALTABAJA = 8,
			PUNTOSDEVENTA_SUPER = 9,
			VENDEDORES_CONSULTAR = 10,
			VENDEDORES_ALTABAJA = 11,
			VENDEDORES_SUPER = 12,
			AUDITORIAS_CONSULTAR = 13
		}

		public static bool usuarioTieneAccesoOperacion(operaciones operacion)
		{
			return usuario.RolId == 1 || usuario.Rol.Operaciones.Any(o => o.Id == (int)operacion);
		}
	}
}
