namespace Lms.Course.Application.DTOs;

public class CourseDto
{
    public int Id { get; set; }
    public string Slug { get; set; } = null!;
    public string Title { get; set; } = null!;

    public string CourseImage { get; set; } = null!;
    public string InstructorImage { get; set; } = null!;
    public string InstructorName { get; set; } = null!;
    public decimal Rating { get; set; }
    public int LessonsCount { get; set; }
    public string Duration { get; set; } = null!;
}
