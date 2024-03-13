using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoAMBE.Migrations
{
    /// <inheritdoc />
    public partial class TablasRegistro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BITACORA",
                columns: table => new
                {
                    ID_BITACORA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false),
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: false),
                    TIPO_ACCION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TABLA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BITACORA__44E70BF3E55560D2", x => x.ID_BITACORA);
                });

            migrationBuilder.CreateTable(
                name: "INSTITUTO_ROLES",
                columns: table => new
                {
                    ID_INSTITUTO_ROL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: false),
                    ID_ROL = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__INSTITUT__F48D85DCA89AB471", x => x.ID_INSTITUTO_ROL);
                });

            migrationBuilder.CreateTable(
                name: "INSTITUTO_USUARIOS",
                columns: table => new
                {
                    ID_INSTITUTO_USUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: false),
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__INSTITUT__74FAE9E1B152300B", x => x.ID_INSTITUTO_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "INSTITUTOS",
                columns: table => new
                {
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NOMBRE_INSTITUTO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RTN = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    TELEFONO = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    DIRECCION = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    EMAIL = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    CREADO_POR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    MODIFICADO_POR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__INSTITUT__E031A83A11780ADE", x => x.ID_INSTITUTO);
                });

            migrationBuilder.CreateTable(
                name: "OBJETOS",
                columns: table => new
                {
                    ID_OBJETO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: true),
                    OBJETO = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "text", nullable: true),
                    TIPO_OBJETO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CREADO_POR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_DE_CREACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    MODIFICADO_POR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_DE_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OBJETOS__6F0599673335FDC3", x => x.ID_OBJETO);
                });

            migrationBuilder.CreateTable(
                name: "PARAMETROS",
                columns: table => new
                {
                    ID_PARAMETRO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PARAMETRO = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    VALOR = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PARAMETR__79032FF56F779CB9", x => x.ID_PARAMETRO);
                });

            migrationBuilder.CreateTable(
                name: "PERMISOS",
                columns: table => new
                {
                    ID_PERMISO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_ROL = table.Column<int>(type: "int", nullable: false),
                    ID_OBJETO = table.Column<int>(type: "int", nullable: false),
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: false),
                    PERMISO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    MODIFICADO_POR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PERMISOS__AC74EBF6D7F3647B", x => x.ID_PERMISO);
                });

            migrationBuilder.CreateTable(
                name: "PERSONAS",
                columns: table => new
                {
                    ID_PERSONA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_TIPO_PERSONA = table.Column<int>(type: "int", nullable: false),
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: false),
                    PRIMER_NOMBRE = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    SEGUNDO_NOMBRE = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    PRIMER_APELLIDO = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    SEGUNDO_APELLIDO = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    FECHA_NACIMIENTO = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GENERO = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    CREADO_POR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    MODIFICADO_POR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ESTADO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__PERSONAS__78244149A2CB5E92", x => x.ID_PERSONA);
                });

            migrationBuilder.CreateTable(
                name: "ROLES",
                columns: table => new
                {
                    ID_ROL = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: false),
                    DESCRIPCION = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    CREADO_POR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())"),
                    MODIFICADO_POR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ROLES__203B0F68D2C5EC61", x => x.ID_ROL);
                });

            migrationBuilder.CreateTable(
                name: "TIPO_PERSONAS",
                columns: table => new
                {
                    ID_TIPO_PERSONA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: false),
                    TIPO_PERSONA = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DESCRIPCION = table.Column<string>(type: "varchar(80)", unicode: false, maxLength: 80, nullable: true),
                    CREADO_POR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    MODIFICADO_POR = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    ESTADO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TIPO_PER__E007574A71D77A60", x => x.ID_TIPO_PERSONA);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_PERSONA = table.Column<int>(type: "int", nullable: true),
                    USUARIO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ID_INSTITUTO = table.Column<int>(type: "int", nullable: true),
                    NOMBRE_USUARIO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CORREO_ELECTRONICO = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    CONTRASEÑA = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    ESTADO = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ID_ROL = table.Column<int>(type: "int", nullable: true),
                    FECHA_ULTIMA_CONEXION = table.Column<DateTime>(type: "datetime", nullable: true),
                    CREADO_POR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_CREACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    MODIFICADO_POR = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    FECHA_MODIFICACION = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__USUARIOS__91136B90BDB3BB42", x => x.ID_USUARIO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BITACORA");

            migrationBuilder.DropTable(
                name: "INSTITUTO_ROLES");

            migrationBuilder.DropTable(
                name: "INSTITUTO_USUARIOS");

            migrationBuilder.DropTable(
                name: "INSTITUTOS");

            migrationBuilder.DropTable(
                name: "OBJETOS");

            migrationBuilder.DropTable(
                name: "PARAMETROS");

            migrationBuilder.DropTable(
                name: "PERMISOS");

            migrationBuilder.DropTable(
                name: "PERSONAS");

            migrationBuilder.DropTable(
                name: "ROLES");

            migrationBuilder.DropTable(
                name: "TIPO_PERSONAS");

            migrationBuilder.DropTable(
                name: "USUARIOS");
        }
    }
}
