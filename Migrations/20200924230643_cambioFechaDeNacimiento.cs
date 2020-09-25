using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ElCondor.Migrations
{
    public partial class cambioFechaDeNacimiento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Empleados");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaDeNacimiento",
                table: "Empleados",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaDeNacimiento",
                table: "Empleados");

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Empleados",
                type: "datetime2",
                nullable: true);
        }
    }
}
