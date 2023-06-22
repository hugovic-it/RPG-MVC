using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPG_MVC.Migrations
{
    /// <inheritdoc />
    public partial class ArmaEImagensInseridos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArmaId",
                table: "Jogadores",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Jogadores",
                type: "TEXT",
                maxLength: 400,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Inimigos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Imagem",
                table: "Armas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Jogadores_ArmaId",
                table: "Jogadores",
                column: "ArmaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogadores_Armas_ArmaId",
                table: "Jogadores",
                column: "ArmaId",
                principalTable: "Armas",
                principalColumn: "ArmaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogadores_Armas_ArmaId",
                table: "Jogadores");

            migrationBuilder.DropIndex(
                name: "IX_Jogadores_ArmaId",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "ArmaId",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Inimigos");

            migrationBuilder.DropColumn(
                name: "Imagem",
                table: "Armas");
        }
    }
}
