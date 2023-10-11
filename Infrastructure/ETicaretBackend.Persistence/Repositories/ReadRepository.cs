using System;
using System.Linq.Expressions;
using ETicaretBackend.Application.Repositories;
using ETicaretBackend.Domain.Entities.Common;
using ETicaretBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ETicaretBackend.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ETicaretDbContext _context;

        public ReadRepository(ETicaretDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }
        
        public T GetById(string id, bool tracking = true)
        {
            //return Table.FirstOrDefault(x=>x.Id == Guid.Parse(id));
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query.FirstOrDefault(x=>x.Id == Guid.Parse(id));
        }

        public T GetSingle(Expression<Func<T, bool>> filter, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query.FirstOrDefault(filter);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> filter, bool tracking = true)
        {
            var query = Table.Where(filter);
            if (!tracking)
            {
                query = query.AsNoTracking();
            }
            return query;
        }
    }
}

