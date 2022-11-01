using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoList.Models;

namespace TodoList.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<TodoIthem> Tasks { get; set; }
    public DbSet<Status> Statuses { get; set; }
    public DbSet<SubTask> SubTasks { get; set; }
}

