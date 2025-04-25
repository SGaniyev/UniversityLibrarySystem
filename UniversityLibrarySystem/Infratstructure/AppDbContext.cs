using Microsoft.EntityFrameworkCore;
using UniversityLibrarySystem.Models;
namespace UniversityLibrarySystem.Infratstructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Section> Sections { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Loan> Loans { get; set; }
}