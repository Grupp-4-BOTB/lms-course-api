using Lms.Course.Application.DTOs;
using Lms.Course.Application.Interfaces;
using Lms.Course.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Lms.Course.Infrastructure.Repositories;

public class InstructorRepository : IInstructorRepository
{
    private readonly CourseDbContext _context;

    public InstructorRepository(CourseDbContext context) 
    {
        _context = context;
    }
    public async Task<InstructorDto?> GetByCourseSlugAsync(string slug, CancellationToken ct)
    {
        return await _context.Courses
            .Include(c => c.Instructor)
            .Where(c => c.Slug == slug && c.Instructor != null)
            .Select(c => new InstructorDto
            {
                Id = c.Instructor!.Id,
                InstructorTitle = c.Instructor.InstructorTitle,
                Biography = c.Instructor.Biography
            })
            .FirstOrDefaultAsync(ct);
    }
}
