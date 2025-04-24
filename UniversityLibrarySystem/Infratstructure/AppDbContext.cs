using Microsoft.EntityFrameworkCore;
using UniversityLibrarySystem.Models;

namespace UniversityLibrarySystem.Infratstructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<Book> Books { get; set; }
}