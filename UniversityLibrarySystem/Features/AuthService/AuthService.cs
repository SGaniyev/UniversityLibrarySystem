using UniversityLibrarySystem.Infratstructure;

namespace UniversityLibrarySystem.Features.AuthService;

public class AuthService : IAuthService
{
    private readonly AppDbContext _context;

    public AuthService(AppDbContext context)
    {
        _context = context;
    }
}