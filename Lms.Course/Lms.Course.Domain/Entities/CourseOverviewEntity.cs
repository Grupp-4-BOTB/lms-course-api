namespace Lms.Course.Domain.Entities;

public class CourseOverviewEntity
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string? DetailImage { get; set; }
    public string? Description { get; set; }
    public string? KeyPoints { get; set; }

    public CourseEntity Course { get; set; } = null!;

}