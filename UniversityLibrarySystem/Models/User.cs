namespace UniversityLibrarySystem.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public int DepartmentId { get; set; }
    public int GroupId { get; set; }
    public Department Department { get; set; }
    public Group Group { get; set; }
    public ICollection<Loan> Loans { get; set; }
}