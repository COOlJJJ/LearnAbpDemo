using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.BookStore.Books
{
    public interface IBookAppService : IApplicationService
    {
        Task<int> CreateAsync(CreateBookDto input);
        Task<int> DeleteBookByNameAsync(string name);
    }
}