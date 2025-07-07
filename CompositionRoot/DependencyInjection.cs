using Microsoft.Extensions.DependencyInjection;
using Orders.Application.UseCases;
using Orders.Domain.Ports;
using Orders.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionRoot
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddSingleton<IOrderRepository, InMemoryOrderRepository>();
            services.AddScoped<CreateOrder>();
            services.AddScoped<GetOrder>();
            return services;
        }
    }
}
