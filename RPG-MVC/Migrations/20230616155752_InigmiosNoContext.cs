using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPG_MVC.Migrations
{
    /// <inheritdoc />
    public partial class InigmiosNoContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Inimigos",
                columns: table => new
                {
                    InimigoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", maxLength: 80, nullable: false),
                    HpMax = table.Column<int>(type: "INTEGER", nullable: false),
                    Hp = table.Column<int>(type: "INTEGER", nullable: false),
                    MpMax = table.Column<int>(type: "INTEGER", nullable: false),
                    Mp = table.Column<int>(type: "INTEGER", nullable: false),
                    Forca = table.Column<int>(type: "INTEGER", nullable: false),
                    Defesa = table.Column<int>(type: "INTEGER", nullable: false),
                    Experiencia = table.Column<int>(type: "INTEGER", nullable: false),
                    Moedas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inimigos", x => x.InimigoId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inimigos");
        }
    }
}
