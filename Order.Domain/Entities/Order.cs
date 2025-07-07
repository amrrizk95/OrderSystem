using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Domain.Entities
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Product { get; set; } = string.Empty;
    }
}
