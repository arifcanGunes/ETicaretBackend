using System;
using System.Linq.Expressions;
using ETicaretBackend.Domain.Entities.Common;

namespace ETicaretBackend.Application.Repositories
{
	public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
	{
		IQueryable<T> GetAll(bool tracking = true);
		IQueryable<T> GetWhere(Expression<Func<T, bool>> filter, bool tracking = true);
		T GetSingle(Expression<Func<T, bool>> filter, bool tracking = true);
		T GetById(string id, bool tracking = true);
	}
}

