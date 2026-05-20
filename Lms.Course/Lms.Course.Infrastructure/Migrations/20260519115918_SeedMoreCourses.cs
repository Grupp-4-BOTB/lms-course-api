using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lms.Course.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedMoreCourses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseImage", "Duration", "InstructorImage", "InstructorName", "LessonsCount", "Rating", "Slug", "Title" },
                values: new object[,]
                {
                    { 2, "/images/courses/data-image.svg", "15 hr 20 min", "/images/courses/Karen.svg", "Karen Hope", 25, 4.7m, "data-science-analytics", "Data Science & Analytics" },
                    { 3, "/images/courses/digital-image.svg", "20 hr 40 min", "/images/courses/Jack.svg", "Jack Sally", 5, 4.8m, "digital-marketing", "Digital Marketing" },
                    { 4, "/images/courses/ux-image.svg", "25 hr 10 min", "/images/courses/Johnny.svg", "Johnny Ahmed", 34, 4.9m, "ui-ux-design-for-beginner", "UI/UX Design for Beginner" },
                    { 5, "/images/courses/fullstack-image.svg", "30 hr 50 min", "/images/courses/Hasan.svg", "Hasan Smith", 30, 4.7m, "fullstack-developer", "Fullstack Developer" },
                    { 6, "/images/courses/sketch-image.svg", "12 hr 15 min", "/images/courses/Jasmin.svg", "Jasmin Lila", 16, 4.5m, "sketch-for-designer", "Sketch for Designer" },
                    { 7, "/images/courses/art-image.svg", "26 hr 15 min", "/images/courses/Jack.svg", "Jack Sally", 24, 4.5m, "network-security", "Network Security" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
