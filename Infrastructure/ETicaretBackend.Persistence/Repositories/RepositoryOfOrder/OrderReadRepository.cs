using System;
using ETicaretBackend.Application.Repositories.RepositoryOfOrder;
using ETicaretBackend.Domain.Entities;
using ETicaretBackend.Persistence.Contexts;

namespace ETicaretBackend.Persistence.Repositories.RepositoryOfOrder
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}

