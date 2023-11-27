using System.Threading.Tasks;
using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Controllers;

/* Inherit your controllers from this class.
 */
// [ApiController]
[ControllerName("TheMyBookStore")]
[Route("api/book")]
public class MyBookStoreController(IBookAppService bookAppService) : BookStoreController
{
    private readonly IBookAppService _bookAppService = bookAppService;

    [Route("getMyBookName")]
    [HttpGet]
    public async Task<int> GetMyBookName(CreateBookDto createBookDto)
    {
        int i = await _bookAppService.CreateAsync(createBookDto);
        return 1;
    }

    [Route("deleteBook")]
    [HttpPost]
    public async Task<int> DeleteBook(string Name)
    {
        int i = await _bookAppService.DeleteBookByNameAsync(Name);
        return 1;
    }
}
