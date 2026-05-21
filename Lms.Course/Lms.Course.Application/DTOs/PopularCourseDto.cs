namespace Lms.Course.Application.DTOs;

public class PopularCourseDto
{
    public int Id { get; set; }
    public string Icon { get; set; } = null!;
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public string Href { get; set; } = null!;
}
