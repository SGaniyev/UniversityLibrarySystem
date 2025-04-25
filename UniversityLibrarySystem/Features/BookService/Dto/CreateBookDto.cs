namespace UniversityLibrarySystem.Features.BookService.Dto;

public class CreateBookDto
{
    public int Id { get; set; }
    public string Title  { get; set; }
    public string Author  { get; set; }
    public long BarCode { get; set; }
    public int CategoryId  { get; set; }
    public int DepartmentId  { get; set; }
    public int SectionId { get; set; }
    public int PublisherYear  { get; set; }
    public int AvalableCopies  { get; set; }
}