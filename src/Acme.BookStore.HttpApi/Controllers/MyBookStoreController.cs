

using System.Threading.Tasks;
using Acme.BookStore.Books;
using Microsoft.AspNetCore.Mvc;

namespace Acme.BookStore.Controllers;

/* Inherit your controllers from this class.
 */
[Controller]
[Route("api/book/")]
public class MyBookStoreController : BookStoreController
{
    private readonly IBookAppService _bookAppService;

    public MyBookStoreController(IBookAppService bookAppService)
    {
        _bookAppService = bookAppService;
    }

    [Route("GetMyBookName")]
    [HttpGet]
    public async Task<int> GetMyBookName(CreateBookDto createBookDto)
    {
        int i = await _bookAppService.CreateAsync(createBookDto);
        return 1;
    }

    [Route("DeleteBook")]
    [HttpGet]
    public int DeleteBook(string Name)
    {
        return 1;
    }
}
