using Microsoft.EntityFrameworkCore.Migrations;

namespace Festify.WebRepository.Migrations.Plan
{
    public partial class AddedPresenterNameAndBio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bio",
                table: "Presenter",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Presenter",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bio",
                table: "Presenter");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Presenter");
        }
    }
}
