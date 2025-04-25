using UniversityLibrarySystem.Models.Enum;

namespace UniversityLibrarySystem.Models;

public class Loan
{
    public int Id { get; set; }
    public int BookId { get; set; }
    public int UserId { get; set; }
    public DateTime DueDate { get; set; }
    public LoanStatus LoanStatus { get; set; }
    public DateTime Borrowed { get; set; }
    public DateTime Returned { get; set; }
    public Book Book { get; set; }
    public User User { get; set; }

}