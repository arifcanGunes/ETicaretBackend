using System;
using ETicaretBackend.Application.Repositories.RepositoryOfProduct;
using ETicaretBackend.Domain.Entities;
using ETicaretBackend.Persistence.Contexts;

namespace ETicaretBackend.Persistence.Repositories.RepositoryOfProduct
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}

