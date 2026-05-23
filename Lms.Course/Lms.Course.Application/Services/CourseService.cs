using Lms.Course.Application.DTOs;
using Lms.Course.Application.Interfaces;

namespace Lms.Course.Application.Services;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _courseRepository;


    public CourseService(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    public Task<List<CourseDto>> GetAllCoursesAsync()
    {
        return _courseRepository.GetAllCoursesAsync();
    }

    public Task<List<PopularCourseDto>> GetPopularCoursesAsync()
    {
        return _courseRepository.GetPopularCoursesAsync();
    }

    public Task<CourseDto?> GetCourseBySlugAsync(string slug)
    {
        return _courseRepository.GetCourseBySlugAsync(slug);
    }
}
