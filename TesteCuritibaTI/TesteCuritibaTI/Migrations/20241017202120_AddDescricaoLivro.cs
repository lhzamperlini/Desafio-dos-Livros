using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteCuritibaTI.Migrations
{
    /// <inheritdoc />
    public partial class AddDescricaoLivro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Livros",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Livros");
        }
    }
}
