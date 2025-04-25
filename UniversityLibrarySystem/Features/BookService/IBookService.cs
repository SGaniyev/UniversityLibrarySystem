using UniversityLibrarySystem.Features.BookService.Dto;

namespace UniversityLibrarySystem.Features.BookService;

public interface IBookService
{
    Task<List<GetBookDto>> GetAll();
    Task<GetBookDto> GetById(int id);
    Task<bool> Create(CreateBookDto createBookDto);
}