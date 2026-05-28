namespace Lms.Course.Domain.Entities;

public class InstructorEntity
{
    public Guid Id { get; set; }
    public int CourseId { get; set; }
    public string InstructorImage { get; set; } = null!;
    public string InstructorName { get; set;} = null!;
    public string InstructorTitle { get; set;} = null!;

    public string Biography { get; set; } = null!;

    public CourseEntity Course { get; set; } = null!;
}
