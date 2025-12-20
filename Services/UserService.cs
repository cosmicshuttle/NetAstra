using Microsoft.EntityFrameworkCore;

namespace AstraArchive.Services;

public class UserService : IUserService
{
    private readonly DbContext _context;

    public UserService(DbContext context)
    {
        _context = context;
    }

    public bool VerifyCredentials(string username, string password)
    {
        return true;
    }
}