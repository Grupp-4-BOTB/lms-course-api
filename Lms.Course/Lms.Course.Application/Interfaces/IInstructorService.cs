using Lms.Course.Application.DTOs;

namespace Lms.Course.Application.Interfaces;

public interface IInstructorService
{
    Task<InstructorDto?> GetByCourseSlugAsync(string slug, CancellationToken ct);
}
