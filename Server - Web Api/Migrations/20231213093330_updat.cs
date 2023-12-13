using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server___Web_Api.Migrations
{
    public partial class updat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CandidatesId",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_CandidatesId",
                table: "Languages",
                column: "CandidatesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Candidates_CandidatesId",
                table: "Languages",
                column: "CandidatesId",
                principalTable: "Candidates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Candidates_CandidatesId",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_CandidatesId",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "CandidatesId",
                table: "Languages");
        }
    }
}
