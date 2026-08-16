using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SisCit_System.Migrations
{
    /// <inheritdoc />
    public partial class CrearTablaNegocios : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Negocios",
                columns: table => new
                {
                    id_negocio = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_negocio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    direccion_negocio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono_negocio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo_negocio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Negocios", x => x.id_negocio);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Negocios");
        }
    }
}
