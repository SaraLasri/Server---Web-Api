using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server___Web_Api.Migrations
{
    public partial class updateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Products_Candidatesid",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Candidates");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Languages");

            migrationBuilder.RenameIndex(
                name: "IX_Category_Candidatesid",
                table: "Languages",
                newName: "IX_Languages_Candidatesid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Languages",
                table: "Languages",
                column: "LanguagesId");

            migrationBuilder.CreateTable(
                name: "LanguagesDetail",
                columns: table => new
                {
                    LanguagesDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguagesId = table.Column<int>(type: "int", nullable: false),
                    CandidatesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagesDetail", x => x.LanguagesDetailId);
                    table.ForeignKey(
                        name: "FK_LanguagesDetail_Candidates_CandidatesId",
                        column: x => x.CandidatesId,
                        principalTable: "Candidates",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LanguagesDetail_Languages_LanguagesId",
                        column: x => x.LanguagesId,
                        principalTable: "Languages",
                        principalColumn: "LanguagesId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LanguagesDetail_CandidatesId",
                table: "LanguagesDetail",
                column: "CandidatesId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagesDetail_LanguagesId",
                table: "LanguagesDetail",
                column: "LanguagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Candidates_Candidatesid",
                table: "Languages",
                column: "Candidatesid",
                principalTable: "Candidates",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Candidates_Candidatesid",
                table: "Languages");

            migrationBuilder.DropTable(
                name: "LanguagesDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Languages",
                table: "Languages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidates",
                table: "Candidates");

            migrationBuilder.RenameTable(
                name: "Languages",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Candidates",
                newName: "Products");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_Candidatesid",
                table: "Category",
                newName: "IX_Category_Candidatesid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "LanguagesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Products_Candidatesid",
                table: "Category",
                column: "Candidatesid",
                principalTable: "Products",
                principalColumn: "id");
        }
    }
}
