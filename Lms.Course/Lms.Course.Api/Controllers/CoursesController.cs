using Microsoft.AspNetCore.Mvc;
using Lms.Course.Application.Interfaces;

namespace Lms.Course.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController : ControllerBase
{
    private readonly ICourseService _courseService;

    public CoursesController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCourses()
    {
        var courses = await _courseService.GetAllCoursesAsync();
        return Ok(courses);
    }

    [HttpGet("{slug}")]
    public async Task<IActionResult> GetCourseBySlug(string slug)
    {
        var course = await _courseService.GetCourseBySlugAsync(slug);

        if (course != null)
        {   
            return Ok(course);
        }
        
        return NotFound();
    }

    [HttpGet("popular")]
    public async Task<IActionResult> GetPopularCourses() 
    {
        var courses = await _courseService.GetPopularCoursesAsync();

        return Ok(courses);
    }
}
