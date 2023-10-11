using System;
using Microsoft.EntityFrameworkCore;
using ETicaretBackend.Persistence.Contexts;
using ETicaretBackend.Application.Repositories.RepositoryOfProduct;
using ETicaretBackend.Persistence.Repositories.RepositoryOfProduct;
using ETicaretBackend.Application.Repositories.RepositoryOfCustomer;
using ETicaretBackend.Persistence.Repositories.RepositoryOfCustomer;
using ETicaretBackend.Application.Repositories.RepositoryOfOrder;
using ETicaretBackend.Persistence.Repositories.RepositoryOfOrder;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretBackend.Persistence
{
	public static class ServiceRegistration
	{
		public static void AddPersistenceServices(this IServiceCollection services)
		{
            services.AddDbContext<ETicaretDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
			services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();

			services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();

			services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        }
    }
}

