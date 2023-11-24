using System;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Books
{
    public class Book : AuditedAggregateRoot<Guid>, ISoftDelete
    {
        public string? Name { get; set; }

        public DateTime PublishDate { get; set; }

        public float Price { get; set; }

        public bool IsDeleted { get; set; }
    }
}
