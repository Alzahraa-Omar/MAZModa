using Microsoft.EntityFrameworkCore.Migrations;

namespace MAZModa.Migrations
{
    public partial class UserTailor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Tailor",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tailor_UserId",
                table: "Tailor",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tailor_AspNetUsers_UserId",
                table: "Tailor",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tailor_AspNetUsers_UserId",
                table: "Tailor");

            migrationBuilder.DropIndex(
                name: "IX_Tailor_UserId",
                table: "Tailor");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Tailor");
        }
    }
}
