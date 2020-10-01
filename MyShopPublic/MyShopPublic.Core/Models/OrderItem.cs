using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopPublic.Core.Models
{
    public class OrderItem: BaseEntity
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string ProdctName { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
    }
}
