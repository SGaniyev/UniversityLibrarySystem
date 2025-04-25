using Microsoft.AspNetCore.Mvc;
using UniversityLibrarySystem.Features.BookService;
using UniversityLibrarySystem.Features.BookService.Dto;

namespace UniversityLibrarySystem.Controllers;

public class BookController : Controller
{
    private readonly IBookService _book;

    public BookController(IBookService book)
    {
        _book = book;
    }
    
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var result = await _book.GetAll();
        return View(result);
    }
}