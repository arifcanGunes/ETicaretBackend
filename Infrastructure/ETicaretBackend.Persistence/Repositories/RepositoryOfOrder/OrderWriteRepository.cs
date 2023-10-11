using System;
using ETicaretBackend.Application.Repositories.RepositoryOfOrder;
using ETicaretBackend.Domain.Entities;
using ETicaretBackend.Persistence.Contexts;

namespace ETicaretBackend.Persistence.Repositories.RepositoryOfOrder
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}

