using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lms.Course.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCourseOverviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CourseOverviews",
                columns: new[] { "Id", "CourseId", "Description", "DetailImage", "KeyPoints" },
                values: new object[,]
                {
                    { 2, 1, "Learn the fundamentals of artificial intelligence and machine learning through practical projects and real-world examples. This course introduces modern AI concepts and helps you understand how intelligent systems are built.", null, "Understand AI basics;Learn machine learning concepts;Work with real-world examples;Explore neural networks;Analyze data patterns;Build simple AI solutions;Understand automation systems;Learn ethical AI principles" },
                    { 3, 2, "Learn how to collect, analyze, and visualize data using modern tools and techniques. This course helps you understand how businesses use data to make informed decisions.", null, "Understand data analysis;Work with datasets;Visualize information clearly;Learn basic statistics;Identify trends and patterns;Use analytical thinking;Create data reports;Understand business insights" },
                    { 4, 4, "Discover the basics of user interface and user experience design. Learn how to create intuitive and visually appealing digital experiences for modern users.", null, "Understand user experience basics;Design clean interfaces;Learn wireframing techniques;Create user-friendly layouts;Improve accessibility;Work with design tools;Understand user behavior;Build responsive designs" },
                    { 5, 5, "Learn both frontend and backend development to build complete web applications. This course covers modern technologies used in fullstack development.", null, "Build responsive frontend interfaces;Understand backend development;Work with APIs;Manage databases;Handle authentication systems;Use modern frameworks;Deploy web applications;Understand fullstack architecture" },
                    { 6, 6, "Learn how to use Sketch for modern digital design projects. This course focuses on creating professional layouts, components, and design systems.", null, "Use Sketch tools effectively;Create reusable components;Design modern layouts;Work with typography;Build design systems;Organize design files;Collaborate with teams;Improve workflow efficiency" },
                    { 7, 7, "Learn the fundamentals of network security and how to protect systems from cyber threats. This course introduces key security concepts used in modern IT environments.", null, "Understand cybersecurity basics;Identify security threats;Protect network systems;Learn encryption concepts;Manage secure connections;Understand firewalls;Prevent common attacks;Improve system security" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CourseOverviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CourseOverviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CourseOverviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CourseOverviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CourseOverviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CourseOverviews",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
