using Orders.Domain.Entities;
using Orders.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Infrastructure.Repositories
{
    public class InMemoryOrderRepository: IOrderRepository
    {
        private readonly Dictionary<Guid, Order> _orders = new();

        public Task AddAsync(Order order)
        {
            _orders[order.Id] = order;
            return Task.CompletedTask;
        }

        public Task<Order?> GetAsync(Guid id)
        {
            _orders.TryGetValue(id, out var order);
            return Task.FromResult(order);
        }
    }
}
