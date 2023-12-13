using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server___Web_Api.Migrations
{
    public partial class updateTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Category_MyPropertyid",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_MyPropertyid",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "MyPropertyid",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Category",
                newName: "LanguagesId");

            migrationBuilder.AddColumn<int>(
                name: "Candidatesid",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Category_Candidatesid",
                table: "Category",
                column: "Candidatesid");

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Products_Candidatesid",
                table: "Category",
                column: "Candidatesid",
                principalTable: "Products",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Category_Products_Candidatesid",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_Candidatesid",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "Candidatesid",
                table: "Category");

            migrationBuilder.RenameColumn(
                name: "LanguagesId",
                table: "Category",
                newName: "id");

            migrationBuilder.AddColumn<int>(
                name: "MyPropertyid",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_MyPropertyid",
                table: "Products",
                column: "MyPropertyid");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Category_MyPropertyid",
                table: "Products",
                column: "MyPropertyid",
                principalTable: "Category",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
