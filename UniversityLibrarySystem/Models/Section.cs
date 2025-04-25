namespace UniversityLibrarySystem.Models;

public class Section
{
    public int Id { get; set; }
    public string Name { get; set; }

    private ICollection<Book> Books { get; set; } = new List<Book>();
}