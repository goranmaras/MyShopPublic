using MyShopPublic.Core.Contracts;
using MyShopPublic.Core.Models;
using MyShopPublic.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShopPublic.Services
{
    public class OrderService : IOrderService
    {
        IRepository<Order> orderContext;
        public OrderService(IRepository<Order> OrderContext)
        {
            this.orderContext = OrderContext;
        }

        public void CreateOrder(Order baseOrder, List<BasketItemViewModel> basketItem)
        {
            foreach(var item in basketItem)
            {
                baseOrder.OrderItems.Add(new OrderItem() { 
                    ProductId = item.Id,
                    Image = item.Image,
                    Price = item.Price,
                    ProdctName = item.ProductName,
                    Quantity = item.Quantity
                });
            }

            orderContext.Insert(baseOrder);
            orderContext.Commit();
        }
    }
}
