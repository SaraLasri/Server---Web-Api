using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server___Web_Api.Migrations
{
    public partial class updatedb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LanguagesDetail_Candidates_CandidatesId",
                table: "LanguagesDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_LanguagesDetail_Languages_LanguagesId",
                table: "LanguagesDetail");

            migrationBuilder.DropIndex(
                name: "IX_LanguagesDetail_CandidatesId",
                table: "LanguagesDetail");

            migrationBuilder.DropIndex(
                name: "IX_LanguagesDetail_LanguagesId",
                table: "LanguagesDetail");

            migrationBuilder.DropColumn(
                name: "CandidatesId",
                table: "LanguagesDetail");

            migrationBuilder.DropColumn(
                name: "LanguagesId",
                table: "LanguagesDetail");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidatesId",
                table: "LanguagesDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LanguagesId",
                table: "LanguagesDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LanguagesDetail_CandidatesId",
                table: "LanguagesDetail",
                column: "CandidatesId");

            migrationBuilder.CreateIndex(
                name: "IX_LanguagesDetail_LanguagesId",
                table: "LanguagesDetail",
                column: "LanguagesId");

            migrationBuilder.AddForeignKey(
                name: "FK_LanguagesDetail_Candidates_CandidatesId",
                table: "LanguagesDetail",
                column: "CandidatesId",
                principalTable: "Candidates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_LanguagesDetail_Languages_LanguagesId",
                table: "LanguagesDetail",
                column: "LanguagesId",
                principalTable: "Languages",
                principalColumn: "LanguagesId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
