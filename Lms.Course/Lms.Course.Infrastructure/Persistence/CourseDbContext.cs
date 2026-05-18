using Lms.Course.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lms.Course.Infrastructure.Persistence;

public class CourseDbContext : DbContext
{
    public CourseDbContext(DbContextOptions<CourseDbContext> options) : base(options)
    {
    }
    public DbSet<CourseEntity> Courses { get; set; } = null!;
}
