using Microsoft.AspNetCore.Mvc;
using Lms.Course.Application.Interfaces;

namespace Lms.Course.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly ICourseRepository _courseRepository;

    public CoursesController(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetCourses()
    {
        var courses = await _courseRepository.GetAllCoursesAsync();
        return Ok(courses);
    }
}
