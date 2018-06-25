namespace Practico1v4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class datainicial : DbMigration
    {
        public override void Up()
        {
			//Sql("SET IDENTITY_INSERT Roles ON");
			Sql("INSERT INTO Roles (Nombre, Privilegio) VALUES (N'Super', 1000)");
			//Sql("INSERT [dbo].[Roles] ([Id], [Nombre], [Privilegio]) VALUES (2, N'Supervisor', 600)");
			//Sql("INSERT [dbo].[Roles] ([Id], [Nombre], [Privilegio]) VALUES (3, N'Auditor', 400)");
			//Sql("INSERT [dbo].[Roles] ([Id], [Nombre], [Privilegio]) VALUES (4, N'Base', 100)");
			//Sql("SET IDENTITY_INSERT [dbo].[Roles] OFF");

			Sql("SET IDENTITY_INSERT [dbo].[Operaciones] ON");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (1, N'SUPER')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (2, N'USUARIOS_CONSULTAR')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (3, N'USUARIOS_MODIFICAR')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (4, N'USUARIOS_ALTABAJA')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (5, N'USUARIOS_SUPER')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (6, N'PUNTOSDEVENTA_CONSULTAR')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (7, N'PUNTOSDEVENTA_MODIFICAR')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (8, N'PUNTOSDEVENTA_ALTABAJA')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (9, N'PUNTOSDEVENTA_SUPER')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (10, N'VENDEDORES_CONSULTAR')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (11, N'VENDEDORES_MODIFICAR')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (12, N'VENDEDORES_ALTABAJA')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (13, N'VENDEDORES_SUPER')");
			Sql("INSERT [dbo].[Operaciones] ([Id], [Nombre]) VALUES (14, N'AUDITORIAS_CONSULTAR')");
			Sql("SET IDENTITY_INSERT [dbo].[Operaciones] OFF");

			
			Sql("INSERT [dbo].[RolOperacions] ([Rol_Id], [Operacion_Id]) VALUES (1, 1)");
			Sql("INSERT [dbo].[RolOperacions] ([Rol_Id], [Operacion_Id]) VALUES (2, 5)");
			Sql("INSERT [dbo].[RolOperacions] ([Rol_Id], [Operacion_Id]) VALUES (4, 6)");
			Sql("INSERT [dbo].[RolOperacions] ([Rol_Id], [Operacion_Id]) VALUES (4, 10)");
			Sql("INSERT [dbo].[RolOperacions] ([Rol_Id], [Operacion_Id]) VALUES (3, 14)");
			

			Sql("SET IDENTITY_INSERT [dbo].[Usuarios] ON");
			Sql("INSERT [dbo].[Usuarios] ([Id], [Username], [Password], [RolId], [Mail]) VALUES (1, N'super', N'$MYHASH$V1$10000$ORJGEFlUuFSyLCDFA4Om0+fZxePwDhchY3QRDpYjww/SM4+M', 1, NULL)");
			Sql("SET IDENTITY_INSERT [dbo].[Usuarios] OFF");
		}
        
        public override void Down()
        {
        }
    }
}
