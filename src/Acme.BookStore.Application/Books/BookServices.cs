using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    //implement the IBookAppService
    [RemoteService(false)]
    public class BookAppService(IRepository<Book, Guid> bookRepository) : BookStoreAppService, IBookAppService
    {
        private readonly IRepository<Book, Guid> _bookRepository = bookRepository;

        public async Task<int> CreateAsync(CreateBookDto input)
        {
            var guid = GuidGenerator.Create();
            var book = ObjectMapper.Map<CreateBookDto, Book>(input);
            await _bookRepository.InsertAsync(book);

            return 1;
        }

        public async Task<int> DeleteBookByNameAsync(string name)
        {
            await _bookRepository.DeleteAsync(x => x.Name == name);
            return 1;
        }
    }
}

