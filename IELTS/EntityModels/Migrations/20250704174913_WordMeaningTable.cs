using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IELTS.EntityModels.Migrations
{
    /// <inheritdoc />
    public partial class WordMeaningTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "WordMeanings",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PartofSpeech = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Pronunciation = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Definition = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    Usage = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    RelatedWords = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    MoreInfo = table.Column<string>(type: "nvarchar(500)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DeletedOn = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordMeanings", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WordMeanings",
                schema: "dbo");
        }
    }
}
