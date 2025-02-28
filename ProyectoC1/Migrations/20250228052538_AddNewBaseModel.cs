using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProyectoC1.Migrations
{
    /// <inheritdoc />
    public partial class AddNewBaseModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Alumnos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Edited",
                table: "Alumnos",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EditedBy",
                table: "Alumnos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Alumnos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "Edited",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "EditedBy",
                table: "Alumnos");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Alumnos");
        }
    }
}
