using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Festify.WebRepository.Migrations.Plan
{
    public partial class AddedDateSubmittedAndDateAccepted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateAccepted",
                table: "Submission",
                type: "DATETIME2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateSubmitted",
                table: "Submission",
                type: "DATETIME2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateAccepted",
                table: "Submission");

            migrationBuilder.DropColumn(
                name: "DateSubmitted",
                table: "Submission");
        }
    }
}
