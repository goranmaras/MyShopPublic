using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyShopPublic.Core.Contracts;
using MyShopPublic.Core.Models;
using MyShopPublic.Core.ViewModels;
using MyShopPublic.WebUI;
using MyShopPublic.WebUI.Controllers;

namespace MyShopPublic.WebUI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        
            [TestMethod]
            public void IndexPageDoesReturnProducts()
            {
            IRepository<Product> productContext = new Mocks.MockContext<Product>();
            IRepository<ProductCategory> productCategoryContext = new Mocks.MockContext<ProductCategory>();

            productContext.Insert(new Product());

            HomeController controller = new HomeController(productContext,productCategoryContext);

            var result = controller.Index() as ViewResult;

            var viewModel = (ProductListViewModel)result.ViewData.Model;

            Assert.AreEqual(1, viewModel.Product.Count());
            }
        


    }
}
