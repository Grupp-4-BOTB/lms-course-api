using Lms.Course.Application.DTOs;
using Lms.Course.Application.Interfaces;

namespace Lms.Course.Application.Services;

public class InstructorService : IInstructorService
{
    private readonly IInstructorRepository _repository;

    public InstructorService(IInstructorRepository repository) 
    {
        _repository = repository;
    }

    public Task<InstructorDto?> GetByCourseSlugAsync(string slug, CancellationToken ct) 
    {
        return _repository.GetByCourseSlugAsync(slug, ct);
    }
}
