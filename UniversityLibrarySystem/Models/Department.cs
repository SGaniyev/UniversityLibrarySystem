namespace UniversityLibrarySystem.Models;
using System.Collections.Generic;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    
    public ICollection<User> Users { get; set; }
    public ICollection<Book> Books { get; set; }
    public ICollection<Group> Groups { get; set; }
}