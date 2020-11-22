using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vic.SportsStore.Domain.Abstract;
using Vic.SportsStore.Domain.Concrete;
using Vic.SportsStore.WebApp.Models;

namespace Vic.SportsStore.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository ProductsRepository { get; set; }
            = new EFProductRepository();

        public int PageSize = 3;

        //public ViewResult List(int page = 1)
        //{
        //    // M-V-C

        //    // M -> ProductsRepository.Products
        //    // V -> View
        //    // C -> ProductController

        //    var model = productsRepository
        //        .Products
        //        .OrderBy(p => p.ProductID)
        //        .Skip((page - 1) * PageSize)
        //        .Take(PageSize);

        //    return View(model);


        //}

        public ViewResult List(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel
            {
                Products = ProductsRepository
            .Products
            .Where(p => category == null || p.Category == category)
            .OrderBy(p => p.ProductId)
            .Skip((page - 1) * PageSize)
            .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = ProductsRepository
                    .Products
                    .Where(p => category == null || p.Category == category)
                    .Count()
                },
                CurrentCategory = category
            };

            return View(model);
        }


    }
}