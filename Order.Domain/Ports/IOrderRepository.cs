using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orders.Domain.Entities;
namespace Orders.Domain.Ports
{
    public interface IOrderRepository
    {
        Task AddAsync(Order order);
        Task<Order?> GetAsync(Guid id);
    }
}
