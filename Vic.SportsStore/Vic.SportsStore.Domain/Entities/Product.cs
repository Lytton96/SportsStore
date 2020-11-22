using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vic.SportsStore.Domain.Entities
{
    public class Product
    {
        public object productId;

        public int ProductID { get; set; }
        public object ProductId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string Category { get; set; }
    }
}
