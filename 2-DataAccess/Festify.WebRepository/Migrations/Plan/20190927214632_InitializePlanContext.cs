using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Festify.WebRepository.Migrations.Plan
{
    public partial class InitializePlanContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Presenter",
                columns: table => new
                {
                    PresenterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presenter", x => x.PresenterId);
                });

            migrationBuilder.CreateTable(
                name: "Talk",
                columns: table => new
                {
                    TalkId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PresenterId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 100, nullable: false),
                    Abstract = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Talk", x => x.TalkId);
                    table.ForeignKey(
                        name: "FK_Talk_Presenter_PresenterId",
                        column: x => x.PresenterId,
                        principalTable: "Presenter",
                        principalColumn: "PresenterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Talk_PresenterId",
                table: "Talk",
                column: "PresenterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Talk");

            migrationBuilder.DropTable(
                name: "Presenter");
        }
    }
}
