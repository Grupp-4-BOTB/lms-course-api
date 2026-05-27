namespace Lms.Course.Application.DTOs;

public class InstructorDto
{
    public Guid Id { get; set; }
    public string InstructorImage { get; set; } = null!;
    public string InstructorName { get; set; } = null!;

    public string InstructorTitle { get; set; } = null!;

    public string Biography { get; set; } = null!;
}
