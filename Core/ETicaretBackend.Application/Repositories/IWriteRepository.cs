using System;
using ETicaretBackend.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace ETicaretBackend.Application.Repositories
{
	public interface IWriteRepository<T> : IRepository<T> where T: BaseEntity 
	{
		bool Add(T model);
		bool AddRange(List<T> models);
		bool Remove(T model);
		bool Remove(string id);
		bool RemoveRange(List<T> models);
		bool Update(T model);
		int Save();
	}
}

