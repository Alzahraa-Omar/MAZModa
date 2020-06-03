using Microsoft.EntityFrameworkCore.Migrations;

namespace MAZModa.Migrations
{
    public partial class oneOnly : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "Note",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDisplayed",
                table: "Note",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Note",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Note",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "IsDisplayed",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Note");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Note");
        }
    }
}
