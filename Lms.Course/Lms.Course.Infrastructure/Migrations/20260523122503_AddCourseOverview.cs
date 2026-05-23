using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lms.Course.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseOverview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CourseOverviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    DetailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KeyPoints = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseOverviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseOverviews_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CourseOverviews",
                columns: new[] { "Id", "CourseId", "Description", "DetailImage", "KeyPoints" },
                values: new object[] { 1, 3, "The class is marketing to help you master the foundation of digital marketing. Through practical lessons and real world case studies. You'll learn how to solve - problem creatively and build impactful solutions.\r\nThis course is designed to help you build a strong understanding of digital marketing from the ground up. Through practical lessons, hands-on exercises, and real-world case studies, you’ll learn how modern brands attract, engage, and convert audiences online.", "/images/courses/course-overview-digital.svg", "Set your marketing goals;Identify your target audience;Choose the right platform;Create compelling content;Launch and monitor your campaign;Pinpoint specific demographics and interests;Often lower cost than traditional advertising;Track performance in real-time" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseOverviews_CourseId",
                table: "CourseOverviews",
                column: "CourseId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseOverviews");
        }
    }
}
