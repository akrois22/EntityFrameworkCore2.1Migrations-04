using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Festify.WebRepository.Migrations.Plan
{
    public partial class AddedSubmission : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Submission",
                columns: table => new
                {
                    SubmissionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TalkId = table.Column<int>(nullable: false),
                    ConferenceId = table.Column<int>(nullable: false),
                    Accepted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Submission", x => x.SubmissionId);
                    table.ForeignKey(
                        name: "FK_Submission_Talk_TalkId",
                        column: x => x.TalkId,
                        principalTable: "Talk",
                        principalColumn: "TalkId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Submission_ConferenceId",
                table: "Submission",
                column: "ConferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Submission_TalkId",
                table: "Submission",
                column: "TalkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Submission");
        }
    }
}
