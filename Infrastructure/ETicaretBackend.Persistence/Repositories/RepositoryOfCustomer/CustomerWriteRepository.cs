using System;
using ETicaretBackend.Application.Repositories.RepositoryOfCustomer;
using ETicaretBackend.Domain.Entities;
using ETicaretBackend.Persistence.Contexts;

namespace ETicaretBackend.Persistence.Repositories.RepositoryOfCustomer
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ETicaretDbContext context) : base(context)
        {
        }
    }
}

