using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IELTS.EntityModels.Migrations
{
    /// <inheritdoc />
    public partial class MyFavoriteWordTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyFavoriteWords",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WordId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyFavoriteWords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MyFavoriteWords_WordMeanings_WordId",
                        column: x => x.WordId,
                        principalSchema: "dbo",
                        principalTable: "WordMeanings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MyFavoriteWords_WordId",
                schema: "dbo",
                table: "MyFavoriteWords",
                column: "WordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyFavoriteWords",
                schema: "dbo");
        }
    }
}
