using System;
using ETicaretBackend.Application.Repositories;
using ETicaretBackend.Domain.Entities.Common;
using ETicaretBackend.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ETicaretBackend.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntity
    {
        private readonly ETicaretDbContext _context;

        public WriteRepository(ETicaretDbContext context)
        {
            _context = context;
        }
        public DbSet<T> Table => _context.Set<T>();

        public bool Add(T model)
        {
            EntityEntry entityEntry =  Table.Add(model);
            return entityEntry.State == EntityState.Added;
        }

        public bool AddRange(List<T> models)
        {
            Table.AddRange(models);
            return true;
        }
        
        public bool Remove(T model)
        {
            EntityEntry entityEntry =  Table.Remove(model);
            return entityEntry.State == EntityState.Deleted;
        }

        public bool Remove(string id)
        {
            T model =  Table.FirstOrDefault(x => x.Id == Guid.Parse(id)) ;
            return Remove(model);
        }

        public bool RemoveRange(List<T> models)
        {
            Table.RemoveRange(models);
            return true;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public bool Update(T model)
        {
            EntityEntry entityEntry = Table.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}

