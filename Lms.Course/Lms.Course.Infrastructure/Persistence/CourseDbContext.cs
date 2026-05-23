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
            }
        );
    }
}
