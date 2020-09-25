using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElCondor.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    IdEmpleado = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<string>(maxLength: 50, nullable: false),
                    NúmeroDocumento = table.Column<int>(nullable: false),
                    Nombres = table.Column<string>(maxLength: 50, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: true),
                    AreaALaQuePertenece = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.IdEmpleado);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
