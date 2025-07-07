using Orders.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Entities;
namespace Orders.Application.UseCases
{
    public class CreateOrder
    {
        private readonly IOrderRepository _repo;
        public CreateOrder(IOrderRepository repo) => _repo = repo;

        public async Task<Guid> ExecuteAsync(string product)
        {
            var order = new Order { Product = product };
            await _repo.AddAsync(order);
            return order.Id;
        }
    }
}
