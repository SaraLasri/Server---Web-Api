using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server___Web_Api.Migrations
{
    public partial class updateT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Candidates_Candidatesid",
                table: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Languages_Candidatesid",
                table: "Languages");

            migrationBuilder.DropColumn(
                name: "Candidatesid",
                table: "Languages");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Candidatesid",
                table: "Languages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Candidatesid",
                table: "Languages",
                column: "Candidatesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Candidates_Candidatesid",
                table: "Languages",
                column: "Candidatesid",
                principalTable: "Candidates",
                principalColumn: "id");
        }
    }
}
