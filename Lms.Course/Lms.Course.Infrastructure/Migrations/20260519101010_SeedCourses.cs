using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lms.Course.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "duration",
                table: "Courses",
                newName: "Duration");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Courses",
                type: "decimal(3,1)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseImage", "Duration", "InstructorImage", "InstructorName", "LessonsCount", "Rating", "Slug", "Title" },
                values: new object[] { 1, "/images/courses/art-image.svg", "10 hr 30 min", "/images/courses/samantha.svg", "Samantha William", 15, 4.9m, "artificial-intelligence", "Artificial Intelligence" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Duration",
                table: "Courses",
                newName: "duration");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Courses",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(3,1)");
        }
    }
}
