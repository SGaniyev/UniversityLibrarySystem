using Microsoft.EntityFrameworkCore;
using UniversityLibrarySystem.Features.BookService.Dto;
using UniversityLibrarySystem.Infratstructure;
using UniversityLibrarySystem.Models;

namespace UniversityLibrarySystem.Features.BookService;

public class BookService : IBookService
{
    private readonly AppDbContext _context;

    public BookService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<GetBookDto>> GetAll()
    {
        var books = await _context.Books
            .Select(b => new GetBookDto
            {
                Id = b.Id,
                Author = b.Author,
                Title = b.Title
            })
            .ToListAsync();
        
        return books;
    }

    public Task<GetBookDto> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<bool> Create(CreateBookDto dto)
    {
        try
        {
            bool isExist = await _context.Books.AnyAsync(b => b.Id == dto.Id);
            if (isExist)
                throw new Exception("Book already exists");

            var result = new Book()
            {
                Title = dto.Title,
                CreatedAt = DateTime.Now.AddHours(5),
                Author = dto.Author,
            };

            return true;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
       
    }
}