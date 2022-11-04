using Microsoft.AspNetCore.Identity;

namespace TodoList.Data.Repository;

public class AdminRepository
{
    ApplicationDbContext _context;
    UserManager<IdentityUser> _userManager;
    
    public AdminRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public IEnumerable<IdentityUser> Get() => _context.Users.ToList();
    
    public IEnumerable<IdentityUser> Create() => _context.Users.ToList();
}