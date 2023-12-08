using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityDataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ChangeGenreTableTogenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Genre",
                table: "Genre");

            migrationBuilder.RenameTable(
                name: "Genre",
                newName: "tb_genre");

            migrationBuilder.RenameColumn(
                name: "GenreName",
                table: "tb_genre",
                newName: "genre");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_genre",
                table: "tb_genre",
                column: "GenreId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_genre",
                table: "tb_genre");

            migrationBuilder.RenameTable(
                name: "tb_genre",
                newName: "Genre");

            migrationBuilder.RenameColumn(
                name: "genre",
                table: "Genre",
                newName: "GenreName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Genre",
                table: "Genre",
                column: "GenreId");
        }
    }
}
