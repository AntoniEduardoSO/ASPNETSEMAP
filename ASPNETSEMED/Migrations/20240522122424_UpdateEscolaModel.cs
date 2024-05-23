using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteMVC.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEscolaModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "lon",
                table: "Escola",
                newName: "Lon");

            migrationBuilder.RenameColumn(
                name: "lat",
                table: "Escola",
                newName: "Lat");

            migrationBuilder.RenameColumn(
                name: "bairro",
                table: "Escola",
                newName: "Bairro");

            migrationBuilder.AddColumn<string>(
                name: "Endereco",
                table: "Escola",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereco",
                table: "Escola");

            migrationBuilder.RenameColumn(
                name: "Lon",
                table: "Escola",
                newName: "lon");

            migrationBuilder.RenameColumn(
                name: "Lat",
                table: "Escola",
                newName: "lat");

            migrationBuilder.RenameColumn(
                name: "Bairro",
                table: "Escola",
                newName: "bairro");
        }
    }
}
