//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(Practico1v4.Models.VentasDBContext),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets7807b44db5c634f4be5358b6d51213f2e503c7a2ddeedb63d83d3a0692e99bf9))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework Power Tools", "0.9.0.0")]
    internal sealed class ViewsForBaseEntitySets7807b44db5c634f4be5358b6d51213f2e503c7a2ddeedb63d83d3a0692e99bf9 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "7807b44db5c634f4be5358b6d51213f2e503c7a2ddeedb63d83d3a0692e99bf9"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "CodeFirstDatabase.PuntoDeVenta")
            {
                return GetView0();
            }

            if (extentName == "CodeFirstDatabase.Vendedor")
            {
                return GetView1();
            }

            if (extentName == "CodeFirstDatabase.Zona")
            {
                return GetView2();
            }

            if (extentName == "VentasDBContext.PuntosDeVenta")
            {
                return GetView3();
            }

            if (extentName == "VentasDBContext.Vendedores")
            {
                return GetView4();
            }

            if (extentName == "VentasDBContext.Zonas")
            {
                return GetView5();
            }

            if (extentName == "CodeFirstDatabase.Rol")
            {
                return GetView6();
            }

            if (extentName == "CodeFirstDatabase.Usuario")
            {
                return GetView7();
            }

            if (extentName == "CodeFirstDatabase.UsuarioRol")
            {
                return GetView8();
            }

            if (extentName == "VentasDBContext.Roles")
            {
                return GetView9();
            }

            if (extentName == "VentasDBContext.Usuarios")
            {
                return GetView10();
            }

            if (extentName == "VentasDBContext.Usuario_Roles")
            {
                return GetView11();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.PuntoDeVenta.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing PuntoDeVenta
        [CodeFirstDatabaseSchema.PuntoDeVenta](T1.PuntoDeVenta_Id, T1.PuntoDeVenta_Descripcion)
    FROM (
        SELECT 
            T.Id AS PuntoDeVenta_Id, 
            T.Descripcion AS PuntoDeVenta_Descripcion, 
            True AS _from0
        FROM VentasDBContext.PuntosDeVenta AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Vendedor.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Vendedor
        [CodeFirstDatabaseSchema.Vendedor](T1.Vendedor_Id, T1.Vendedor_PuntoDeVentaId, T1.Vendedor_Nombre, T1.Vendedor_Apellido, T1.Vendedor_ZonaId)
    FROM (
        SELECT 
            T.Id AS Vendedor_Id, 
            T.PuntoDeVentaId AS Vendedor_PuntoDeVentaId, 
            T.Nombre AS Vendedor_Nombre, 
            T.Apellido AS Vendedor_Apellido, 
            T.ZonaId AS Vendedor_ZonaId, 
            True AS _from0
        FROM VentasDBContext.Vendedores AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Zona.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Zona
        [CodeFirstDatabaseSchema.Zona](T1.Zona_Id, T1.Zona_Descripcion)
    FROM (
        SELECT 
            T.Id AS Zona_Id, 
            T.Descripcion AS Zona_Descripcion, 
            True AS _from0
        FROM VentasDBContext.Zonas AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for VentasDBContext.PuntosDeVenta.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing PuntosDeVenta
        [Practico1v4.Models.PuntoDeVenta](T1.PuntoDeVenta_Id, T1.PuntoDeVenta_Descripcion)
    FROM (
        SELECT 
            T.Id AS PuntoDeVenta_Id, 
            T.Descripcion AS PuntoDeVenta_Descripcion, 
            True AS _from0
        FROM CodeFirstDatabase.PuntoDeVenta AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for VentasDBContext.Vendedores.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Vendedores
        [Practico1v4.Models.Vendedor](T1.Vendedor_Id, T1.Vendedor_PuntoDeVentaId, T1.Vendedor_Nombre, T1.Vendedor_Apellido, T1.Vendedor_ZonaId)
    FROM (
        SELECT 
            T.Id AS Vendedor_Id, 
            T.PuntoDeVentaId AS Vendedor_PuntoDeVentaId, 
            T.Nombre AS Vendedor_Nombre, 
            T.Apellido AS Vendedor_Apellido, 
            T.ZonaId AS Vendedor_ZonaId, 
            True AS _from0
        FROM CodeFirstDatabase.Vendedor AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for VentasDBContext.Zonas.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Zonas
        [Practico1v4.Models.Zona](T1.Zona_Id, T1.Zona_Descripcion)
    FROM (
        SELECT 
            T.Id AS Zona_Id, 
            T.Descripcion AS Zona_Descripcion, 
            True AS _from0
        FROM CodeFirstDatabase.Zona AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Rol.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Rol
        [CodeFirstDatabaseSchema.Rol](T1.Rol_Id, T1.Rol_Nombre, T1.Rol_Privilegio)
    FROM (
        SELECT 
            T.Id AS Rol_Id, 
            T.Nombre AS Rol_Nombre, 
            T.Privilegio AS Rol_Privilegio, 
            True AS _from0
        FROM VentasDBContext.Roles AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.Usuario.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Usuario
        [CodeFirstDatabaseSchema.Usuario](T1.Usuario_Id, T1.Usuario_Username, T1.Usuario_Password)
    FROM (
        SELECT 
            T.Id AS Usuario_Id, 
            T.Username AS Usuario_Username, 
            T.Password AS Usuario_Password, 
            True AS _from0
        FROM VentasDBContext.Usuarios AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for CodeFirstDatabase.UsuarioRol.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing UsuarioRol
        [CodeFirstDatabaseSchema.UsuarioRol](T1.[UsuarioRol.Usuario_Id], T1.[UsuarioRol.Rol_Id])
    FROM (
        SELECT 
            Key(T.Usuario_Roles_Source).Id AS [UsuarioRol.Usuario_Id], 
            Key(T.Usuario_Roles_Target).Id AS [UsuarioRol.Rol_Id], 
            True AS _from0
        FROM VentasDBContext.Usuario_Roles AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for VentasDBContext.Roles.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Roles
        [Practico1v4.Models.Rol](T1.Rol_Id, T1.Rol_Nombre, T1.Rol_Privilegio)
    FROM (
        SELECT 
            T.Id AS Rol_Id, 
            T.Nombre AS Rol_Nombre, 
            T.Privilegio AS Rol_Privilegio, 
            True AS _from0
        FROM CodeFirstDatabase.Rol AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for VentasDBContext.Usuarios.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Usuarios
        [Practico1v4.Models.Usuario](T1.Usuario_Id, T1.Usuario_Username, T1.Usuario_Password)
    FROM (
        SELECT 
            T.Id AS Usuario_Id, 
            T.Username AS Usuario_Username, 
            T.Password AS Usuario_Password, 
            True AS _from0
        FROM CodeFirstDatabase.Usuario AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for VentasDBContext.Usuario_Roles.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Usuario_Roles
        [Practico1v4.Models.Usuario_Roles](T3.[Usuario_Roles.Usuario_Roles_Source], T3.[Usuario_Roles.Usuario_Roles_Target])
    FROM (
        SELECT -- Constructing Usuario_Roles_Source
            CreateRef(VentasDBContext.Usuarios, row(T2.[Usuario_Roles.Usuario_Roles_Source.Id]), [Practico1v4.Models.Usuario]) AS [Usuario_Roles.Usuario_Roles_Source], 
            T2.[Usuario_Roles.Usuario_Roles_Target]
        FROM (
            SELECT -- Constructing Usuario_Roles_Target
                T1.[Usuario_Roles.Usuario_Roles_Source.Id], 
                CreateRef(VentasDBContext.Roles, row(T1.[Usuario_Roles.Usuario_Roles_Target.Id]), [Practico1v4.Models.Rol]) AS [Usuario_Roles.Usuario_Roles_Target]
            FROM (
                SELECT 
                    T.Usuario_Id AS [Usuario_Roles.Usuario_Roles_Source.Id], 
                    T.Rol_Id AS [Usuario_Roles.Usuario_Roles_Target.Id], 
                    True AS _from0
                FROM CodeFirstDatabase.UsuarioRol AS T
            ) AS T1
        ) AS T2
    ) AS T3");
        }
    }
}
