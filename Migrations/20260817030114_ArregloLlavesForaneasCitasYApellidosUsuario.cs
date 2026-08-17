using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisCit_System.Migrations
{
    /// <inheritdoc />
    public partial class ArregloLlavesForaneasCitasYApellidosUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Negocios_Negocioid_negocio",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Servicios_Servicioid_servicio",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Usuarios_Usuarioid_usuario",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_Negocioid_negocio",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_Servicioid_servicio",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_Usuarioid_usuario",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "Negocioid_negocio",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "Servicioid_servicio",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "Usuarioid_usuario",
                table: "Citas");

            migrationBuilder.AddColumn<string>(
                name: "apellidoMat_usuario",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "apellidoPat_usuario",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_id_negocio",
                table: "Citas",
                column: "id_negocio");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_id_servicio",
                table: "Citas",
                column: "id_servicio");

            migrationBuilder.CreateIndex(
                name: "IX_Citas_id_usuario",
                table: "Citas",
                column: "id_usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Negocios_id_negocio",
                table: "Citas",
                column: "id_negocio",
                principalTable: "Negocios",
                principalColumn: "id_negocio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Servicios_id_servicio",
                table: "Citas",
                column: "id_servicio",
                principalTable: "Servicios",
                principalColumn: "id_servicio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Usuarios_id_usuario",
                table: "Citas",
                column: "id_usuario",
                principalTable: "Usuarios",
                principalColumn: "id_usuario",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Negocios_id_negocio",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Servicios_id_servicio",
                table: "Citas");

            migrationBuilder.DropForeignKey(
                name: "FK_Citas_Usuarios_id_usuario",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_id_negocio",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_id_servicio",
                table: "Citas");

            migrationBuilder.DropIndex(
                name: "IX_Citas_id_usuario",
                table: "Citas");

            migrationBuilder.DropColumn(
                name: "apellidoMat_usuario",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "apellidoPat_usuario",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "Negocioid_negocio",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Servicioid_servicio",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Usuarioid_usuario",
                table: "Citas",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Negocios_Negocioid_negocio",
                table: "Citas",
                column: "Negocioid_negocio",
                principalTable: "Negocios",
                principalColumn: "id_negocio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Servicios_Servicioid_servicio",
                table: "Citas",
                column: "Servicioid_servicio",
                principalTable: "Servicios",
                principalColumn: "id_servicio",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Citas_Usuarios_Usuarioid_usuario",
                table: "Citas",
                column: "Usuarioid_usuario",
                principalTable: "Usuarios",
                principalColumn: "id_usuario",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
