using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TesteMVC.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaAnydesk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anydesk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "text", nullable: false),
                    Escola = table.Column<string>(type: "text", nullable: false),
                    Patrimonio = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anydesk", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Anydesk");
        }
    }
}
