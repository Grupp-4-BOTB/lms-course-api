using Lms.Course.Application.DTOs;
using Lms.Course.Application.Interfaces;
using Lms.Course.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Lms.Course.Infrastructure.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly CourseDbContext _context;

    public CourseRepository(CourseDbContext context)
    {
        _context = context;
    }
    public async Task<List<CourseDto>> GetAllCoursesAsync()
    {
        return await _context.Courses
            .Select(c => new CourseDto
            {
                Id = c.Id,
                Slug = c.Slug,
                Title = c.Title,
                CourseImage = c.CourseImage,
                InstructorImage = c.InstructorImage,
                InstructorName = c.InstructorName,
                Rating = c.Rating,
                LessonsCount = c.LessonsCount,
                Duration = c.Duration
            })
            .ToListAsync();
    }

    public async Task<CourseDto?> GetCourseBySlugAsync(string slug)
    {
        return await _context.Courses
            .Where(c => c.Slug == slug)
            .Select(c => new CourseDto
            {
                Id = c.Id,
                Slug = c.Slug,
                Title = c.Title,
                CourseImage = c.CourseImage,
                InstructorImage = c.InstructorImage,
                InstructorName = c.InstructorName,
                Rating = c.Rating,
                LessonsCount = c.LessonsCount,
                Duration = c.Duration
            })
            .FirstOrDefaultAsync();
    }
    public async Task<List<PopularCourseDto>> GetPopularCoursesAsync()
    {
        return await _context.Courses
            .OrderByDescending(c => c.Rating)
            .Take(4)
            .Select(c => new PopularCourseDto
            {
                Id = c.Id,
                Title = c.Title,
                Description = c.Description ?? string.Empty,
                Icon = c.Icon ?? string.Empty,
                Href = $"/courses/{c.Slug}" 

            })
            .ToListAsync();
    }
}
