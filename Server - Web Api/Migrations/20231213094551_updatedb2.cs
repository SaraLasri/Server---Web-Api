using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server___Web_Api.Migrations
{
    public partial class updatedb2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Languages_Candidates_CandidatesId",
                table: "Languages");

            migrationBuilder.DropTable(
                name: "LanguagesDetail");

            migrationBuilder.RenameColumn(
                name: "CandidatesId",
                table: "Languages",
                newName: "Candidatesid");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_CandidatesId",
                table: "Languages",
                newName: "IX_Languages_Candidatesid");

            migrationBuilder.AlterColumn<int>(
                name: "Candidatesid",
                table: "Languages",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.RenameColumn(
                name: "Candidatesid",
                table: "Languages",
                newName: "CandidatesId");

            migrationBuilder.RenameIndex(
                name: "IX_Languages_Candidatesid",
                table: "Languages",
                newName: "IX_Languages_CandidatesId");

            migrationBuilder.AlterColumn<int>(
                name: "CandidatesId",
                table: "Languages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "LanguagesDetail",
                columns: table => new
                {
                    LanguagesDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LanguagesDetail", x => x.LanguagesDetailId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Languages_Candidates_CandidatesId",
                table: "Languages",
                column: "CandidatesId",
                principalTable: "Candidates",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
