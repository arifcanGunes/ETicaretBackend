using System;
using ETicaretBackend.Application.Repositories.RepositoryOfProduct;
using ETicaretBackend.Domain.Entities;
using ETicaretBackend.Persistence.Contexts;

namespace ETicaretBackend.Persistence.Repositories.RepositoryOfProduct
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}

