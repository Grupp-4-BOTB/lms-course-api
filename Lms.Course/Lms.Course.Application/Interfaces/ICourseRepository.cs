using Lms.Course.Application.DTOs;

namespace Lms.Course.Application.Interfaces;

public interface ICourseRepository
{
    Task<List<CourseDto>> GetAllCoursesAsync();
    Task<CourseDto?> GetCourseBySlugAsync(string slug);
}
