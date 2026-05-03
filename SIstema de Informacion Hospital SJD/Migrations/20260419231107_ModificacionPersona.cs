using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIstema_de_Informacion_Hospital_SJD.Migrations
{
    /// <inheritdoc />
    public partial class ModificacionPersona : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Personas");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
