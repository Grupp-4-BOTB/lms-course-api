using Lms.Course.Application.DTOs;

namespace Lms.Course.Application.Interfaces;

public interface IInstructorRepository
{
    Task<InstructorDto?> GetByCourseSlugAsync(string slug, CancellationToken ct);

}
