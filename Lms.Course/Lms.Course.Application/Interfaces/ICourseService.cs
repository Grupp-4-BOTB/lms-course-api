using Lms.Course.Application.DTOs;

namespace Lms.Course.Application.Interfaces;

public interface ICourseService
{
    Task<List<CourseDto>> GetAllCoursesAsync();
    Task<List<PopularCourseDto>> GetPopularCoursesAsync();
    Task<CourseDto?> GetCourseBySlugAsync(string slug);
}
