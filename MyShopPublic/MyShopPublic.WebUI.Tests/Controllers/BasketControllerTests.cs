using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShopPublic.Core.Contracts;
using MyShopPublic.Core.Models;
using MyShopPublic.Core.ViewModels;
using MyShopPublic.Services;
using MyShopPublic.WebUI.Controllers;
using MyShopPublic.WebUI.Tests.Mocks;

namespace MyShopPublic.WebUI.Tests.Controllers
{
    [TestClass]
    public class BasketControllerTests
    {
        [TestMethod]
        public void CanAddBasketItem()
        {
            //IRepository<Basket> basketContext = new MockContext<Basket>();
            //IRepository<Product> productContext = new MockContext<Product>();
            //var httpContext = new MockHttpContext();

            //IBasketService basketService = new BasketService(productContext, basketContext);
            //var controller = new BasketController(basketService);
            //controller.ControllerContext = new System.Web.Mvc.ControllerContext(httpContext, new System.Web.Routing.RouteData(), controller);

            ////basketService.AddToBasket(httpContext, "1");
            //controller.AddToBasket("1");

            //Basket basket = basketContext.Collection().FirstOrDefault();

            //Assert.IsNotNull(basket);
            //Assert.AreEqual(1, basket.BasketItems.Count);
            //Assert.AreEqual("1", basket.BasketItems.ToList().FirstOrDefault().ProductId);
        }

        [TestMethod]
        public void CanGetSummaryViewModel() {
            //IRepository<Basket> basketContext = new MockContext<Basket>();
            //IRepository<Product> productContext = new MockContext<Product>();

            //productContext.Insert(new Product() { Id = "1", Price = 10 });
            //productContext.Insert(new Product() { Id = "2", Price = 5 });
            //productContext.Insert(new Product() { Id = "3", Price = 5 });

            //Basket basket = new Basket();
            //basket.BasketItems.Add(new BasketItem() { ProductId = "1", Quantity = 2 });
            //basket.BasketItems.Add(new BasketItem() { ProductId = "2", Quantity = 3 });
            //basket.BasketItems.Add(new BasketItem() { ProductId = "3", Quantity = 5 });
            //basketContext.Insert(basket);

            //IBasketService basketService = new BasketService(productContext, basketContext);

            //var controller = new BasketController(basketService);
            //var httpContext = new MockHttpContext();
            //httpContext.Request.Cookies.Add(new System.Web.HttpCookie("eCommerce") { Value = basket.Id });
            //controller.ControllerContext = new System.Web.Mvc.ControllerContext(httpContext, new System.Web.Routing.RouteData(), controller);

            //var result = controller.BasketSummary() as PartialViewResult;
            //var basketSummary = (BasketSummaryViewModel)result.ViewData.Model;

            //Assert.AreEqual(15, basketSummary.BasketCount);
            //Assert.AreEqual(60, basketSummary.BasketTotal);



        }


    }
}
