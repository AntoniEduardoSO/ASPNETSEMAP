using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnsToEscolaModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Ra",
                table: "Escola",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "bairro",
                table: "Escola",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "lat",
                table: "Escola",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "lon",
                table: "Escola",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ra",
                table: "Escola");

            migrationBuilder.DropColumn(
                name: "bairro",
                table: "Escola");

            migrationBuilder.DropColumn(
                name: "lat",
                table: "Escola");

            migrationBuilder.DropColumn(
                name: "lon",
                table: "Escola");
        }
    }
}
