using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi.Migrations
{
    public partial class FixCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vinyl_Category_MusicCategoryId",
                table: "Vinyl");

            migrationBuilder.DropIndex(
                name: "IX_Vinyl_MusicCategoryId",
                table: "Vinyl");

            migrationBuilder.DropColumn(
                name: "MusicCategoryId",
                table: "Vinyl");

            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Vinyl",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Vinyl",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vinyl_CategoryID",
                table: "Vinyl",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyl_Category_CategoryID",
                table: "Vinyl",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vinyl_Category_CategoryID",
                table: "Vinyl");

            migrationBuilder.DropIndex(
                name: "IX_Vinyl_CategoryID",
                table: "Vinyl");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Vinyl");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Vinyl");

            migrationBuilder.AddColumn<int>(
                name: "MusicCategoryId",
                table: "Vinyl",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vinyl_MusicCategoryId",
                table: "Vinyl",
                column: "MusicCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vinyl_Category_MusicCategoryId",
                table: "Vinyl",
                column: "MusicCategoryId",
                principalTable: "Category",
                principalColumn: "Id");
        }
    }
}
