using System;
using Volo.Abp.Application.Dtos;

namespace Acme.BookStore.Books
{
    public class CreateBookDto : EntityDto<Guid>
    {
        public string? Name { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }
    }
}