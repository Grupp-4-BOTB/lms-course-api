using Lms.Course.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lms.Course.Api.Controllers;

[Route("api/Courses")]
[ApiController]
public class InstructorsController : ControllerBase
{
    private readonly IInstructorService _instructorservice;

    public InstructorsController(IInstructorService service) 
    {
        _instructorservice = service;
    }

    [HttpGet("{slug}/instructor")]
    public async Task<IActionResult> GetInstructor(string slug, CancellationToken ct) 
    {
        var instructor = await _instructorservice.GetByCourseSlugAsync(slug, ct);

        if (instructor == null)
            return NotFound();

        return Ok(instructor);
    }
}
