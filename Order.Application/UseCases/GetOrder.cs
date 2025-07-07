using Orders.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Entities;
namespace Orders.Application.UseCases
{
    public class GetOrder
    {
        private readonly IOrderRepository _repo;
        public GetOrder(IOrderRepository repo) => _repo = repo;

        public Task<Order?> ExecuteAsync(Guid id) => _repo.GetAsync(id);
    }
}
