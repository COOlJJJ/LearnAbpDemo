using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acme.BookStore.Books;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Acme.BookStore.EntityFrameworkCore
{
    /// <summary>
    /// 定义自己的业务表,独立于Abp的基础表
    /// </summary>
    [ConnectionStringName("Domain")]
    public class MyBookStoreDbContext : AbpDbContext<MyBookStoreDbContext>
    {
        public MyBookStoreDbContext(DbContextOptions<MyBookStoreDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Book>(b =>
                {
                    b.ToTable(BookStoreConsts.DbTablePrefix + "Books",
                        BookStoreConsts.DbSchema);
                    b.ConfigureByConvention(); //auto configure for the base class props
                    b.Property(x => x.Name).IsRequired().HasMaxLength(128);
                });
        }
    }
}