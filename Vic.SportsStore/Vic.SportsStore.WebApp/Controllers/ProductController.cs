using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository productsRepository { get; set; }
            = new InMemoryProductRepository();
        public ViewResult List()
        {
            // M-V-C

            // M -> ProductsRepository.Products
            // V -> View
            // C -> ProductController

            return View(productsRepository.Products);
        }

    }
}