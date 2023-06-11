using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPG_MVC.Migrations
{
    /// <inheritdoc />
    public partial class ArmasModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Armas",
                columns: table => new
                {
                    ArmaId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 80, nullable: true),
                    Descricao = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true),
                    Ataque = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armas", x => x.ArmaId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Armas");
        }
    }
}
