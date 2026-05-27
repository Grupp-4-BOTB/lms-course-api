using Lms.Course.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lms.Course.Infrastructure.Persistence;

public class CourseDbContext : DbContext
{
    public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
    {
    }
    public DbSet<CourseEntity> Courses { get; set; } = null!;
    public DbSet<CourseOverviewEntity> CourseOverviews { get; set; } = null!;

    public DbSet<InstructorEntity> Instructors { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CourseEntity>()
            .Property(c => c.Rating)
            .HasColumnType("decimal(3,1)");

        modelBuilder.Entity<CourseEntity>().HasData(
            new CourseEntity 
            { 
                Id = 1,
                Slug = "artificial-intelligence",
                CourseImage ="/images/courses/art-image.svg",
                Title = "Artificial Intelligence",
                InstructorImage = "/images/courses/samantha.svg",
                InstructorName = "Samantha William",
                Rating = 4.9m,
                LessonsCount = 15,
                Duration = "10 hr 30 min",
            },
            new CourseEntity
            {
                Id = 2,
                Slug = "data-science-analytics",
                CourseImage = "/images/courses/data-image.svg",
                Title = "Data Science & Analytics",
                InstructorImage = "/images/courses/Karen.svg",
                InstructorName = "Karen Hope",
                Rating = 4.7m,
                LessonsCount = 25,
                Duration = "15 hr 20 min",
            },
            new CourseEntity
            {
                Id = 3,
                Slug = "digital-marketing",
                CourseImage = "/images/courses/digital-image.svg",
                Title = "Digital Marketing",
                InstructorImage = "/images/courses/Jack.svg",
                InstructorName = "Jack Sally",
                Rating = 4.8m,
                LessonsCount = 5,
                Duration = "20 hr 40 min",
            },
            new CourseEntity
            {
                Id = 4,
                Slug = "ui-ux-design-for-beginner",
                CourseImage = "/images/courses/ux-image.svg",
                Title = "UI/UX Design for Beginner",
                InstructorImage = "/images/courses/Johnny.svg",
                InstructorName = "Johnny Ahmed",
                Rating = 4.9m,
                LessonsCount = 34,
                Duration = "25 hr 10 min",
            },
            new CourseEntity
            {
                Id = 5,
                Slug = "fullstack-developer",
                CourseImage = "/images/courses/fullstack-image.svg",
                Title = "Fullstack Developer",
                InstructorImage = "/images/courses/Hasan.svg",
                InstructorName = "Hasan Smith",
                Rating = 4.7m,
                LessonsCount = 30,
                Duration = "30 hr 50 min",
            },
            new CourseEntity
            {
                Id = 6,
                Slug = "sketch-for-designer",
                CourseImage = "/images/courses/sketch-image.svg",
                Title = "Sketch for Designer",
                InstructorImage = "/images/courses/Jasmin.svg",
                InstructorName = "Jasmin Lila",
                Rating = 4.5m,
                LessonsCount = 16,
                Duration = "12 hr 15 min",
            },
            new CourseEntity
            {
                Id = 7,
                Slug = "network-security",
                CourseImage = "/images/courses/art-image.svg",
                Title = "Network Security",
                InstructorImage = "/images/courses/Jack.svg",
                InstructorName = "Jack Sally",
                Rating = 4.5m,
                LessonsCount = 24,
                Duration = "26 hr 15 min",
            }
        );


        modelBuilder.Entity<CourseEntity>()
            .HasOne(c => c.CourseOverview)
            .WithOne(co => co.Course)
            .HasForeignKey<CourseOverviewEntity>(co => co.CourseId);

        modelBuilder.Entity<CourseOverviewEntity>().HasData(
            new CourseOverviewEntity
            {
                Id = 1,
                CourseId = 3,
                DetailImage = "/images/courses/course-overview-digital.svg",
                Description = "The class is marketing to help you master the foundation of digital marketing. Through practical lessons and real world case studies. You'll learn how to solve - problem creatively and build impactful solutions.\r\nThis course is designed to help you build a strong understanding of digital marketing from the ground up. Through practical lessons, hands-on exercises, and real-world case studies, you’ll learn how modern brands attract, engage, and convert audiences online.",
                KeyPoints = "Set your marketing goals;Identify your target audience;Choose the right platform;Create compelling content;Launch and monitor your campaign;Pinpoint specific demographics and interests;Often lower cost than traditional advertising;Track performance in real-time"
            },
            new CourseOverviewEntity
            {
                Id = 2,
                CourseId = 1,
                Description = "Learn the fundamentals of artificial intelligence and machine learning through practical projects and real-world examples. This course introduces modern AI concepts and helps you understand how intelligent systems are built.",
                KeyPoints = "Understand AI basics;Learn machine learning concepts;Work with real-world examples;Explore neural networks;Analyze data patterns;Build simple AI solutions;Understand automation systems;Learn ethical AI principles"
            },
            new CourseOverviewEntity
            {
                Id = 3,
                CourseId = 2,
                Description = "Learn how to collect, analyze, and visualize data using modern tools and techniques. This course helps you understand how businesses use data to make informed decisions.",
                KeyPoints = "Understand data analysis;Work with datasets;Visualize information clearly;Learn basic statistics;Identify trends and patterns;Use analytical thinking;Create data reports;Understand business insights"
            },
            new CourseOverviewEntity
            {
                Id = 4,
                CourseId = 4,
                Description = "Discover the basics of user interface and user experience design. Learn how to create intuitive and visually appealing digital experiences for modern users.",
                KeyPoints = "Understand user experience basics;Design clean interfaces;Learn wireframing techniques;Create user-friendly layouts;Improve accessibility;Work with design tools;Understand user behavior;Build responsive designs"
            },
            new CourseOverviewEntity
            {
                Id = 5,
                CourseId = 5,
                Description = "Learn both frontend and backend development to build complete web applications. This course covers modern technologies used in fullstack development.",
                KeyPoints = "Build responsive frontend interfaces;Understand backend development;Work with APIs;Manage databases;Handle authentication systems;Use modern frameworks;Deploy web applications;Understand fullstack architecture"
            },
            new CourseOverviewEntity
            {
                Id = 6,
                CourseId = 6,
                Description = "Learn how to use Sketch for modern digital design projects. This course focuses on creating professional layouts, components, and design systems.",
                KeyPoints = "Use Sketch tools effectively;Create reusable components;Design modern layouts;Work with typography;Build design systems;Organize design files;Collaborate with teams;Improve workflow efficiency"
            },
            new CourseOverviewEntity
            {
                Id = 7,
                CourseId = 7,
                Description = "Learn the fundamentals of network security and how to protect systems from cyber threats. This course introduces key security concepts used in modern IT environments.",
                KeyPoints = "Understand cybersecurity basics;Identify security threats;Protect network systems;Learn encryption concepts;Manage secure connections;Understand firewalls;Prevent common attacks;Improve system security"
            }
        );
        modelBuilder.Entity<CourseEntity>()
           .HasOne(c => c.Instructor)
           .WithOne(i => i.Course)
           .HasForeignKey<InstructorEntity>(i => i.CourseId);
    }
}
