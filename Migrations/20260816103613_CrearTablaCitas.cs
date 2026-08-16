using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisCit_System.Migrations
{
    /// <inheritdoc />
    public partial class CrearTablaCitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Citas",
                columns: table => new
                {
                    id_cita = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_cita = table.Column<DateTime>(type: "datetime2", nullable: false),
                    hora_cita = table.Column<TimeSpan>(type: "time", nullable: false),
                    id_servicio = table.Column<int>(type: "int", nullable: false),
                    id_usuario = table.Column<int>(type: "int", nullable: false),
                    id_negocio = table.Column<int>(type: "int", nullable: false),
                    Servicioid_servicio = table.Column<int>(type: "int", nullable: false),
                    Usuarioid_usuario = table.Column<int>(type: "int", nullable: false),
                    Negocioid_negocio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citas", x => x.id_cita);
                    table.ForeignKey(
                        name: "FK_Citas_Negocios_Negocioid_negocio",
                        column: x => x.Negocioid_negocio,
                        principalTable: "Negocios",
                        principalColumn: "id_negocio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_Servicios_Servicioid_servicio",
                        column: x => x.Servicioid_servicio,
                        principalTable: "Servicios",
                        principalColumn: "id_servicio",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Citas_Usuarios_Usuarioid_usuario",
                        column: x => x.Usuarioid_usuario,
                        principalTable: "Usuarios",
                        principalColumn: "id_usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citas_Negocioid_negocio",
                table: "Citas",
                column: "Negocioid_negocio");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_Servicioid_servicio",
                table: "Citas",
                column: "Servicioid_servicio");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_Usuarioid_usuario",
                table: "Citas",
                column: "Usuarioid_usuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citas");
        }
    }
}
