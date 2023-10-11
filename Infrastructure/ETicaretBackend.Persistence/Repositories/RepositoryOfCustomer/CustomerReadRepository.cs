using System;
using ETicaretBackend.Application.Repositories.RepositoryOfCustomer;
using ETicaretBackend.Domain.Entities;
using ETicaretBackend.Persistence.Contexts;

namespace ETicaretBackend.Persistence.Repositories.RepositoryOfCustomer
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}

