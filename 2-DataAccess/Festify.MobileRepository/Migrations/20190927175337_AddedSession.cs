using Microsoft.EntityFrameworkCore.Migrations;

namespace Festify.MobileRepository.Migrations
{
    public partial class AddedSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Session",
                columns: table => new
                {
                    SessionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Abstract = table.Column<string>(nullable: false),
                    SpeakerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Session", x => x.SessionId);
                    table.ForeignKey(
                        name: "FK_Session_Speaker_SpeakerId",
                        column: x => x.SpeakerId,
                        principalTable: "Speaker",
                        principalColumn: "SpeakerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Session_SpeakerId",
                table: "Session",
                column: "SpeakerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Session");
        }
    }
}
