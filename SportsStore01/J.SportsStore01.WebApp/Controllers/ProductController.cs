using J.SportsStore01.Domain.Abstract;
using J.SportsStore01.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace J.SportsStore01.WebApp.Controllers
{
    public class ProductController : Controller
    {
        public IProductsRepository ProductsRepository { get; set; } 
            = new InMemoryProductsRepository();
        public ViewResult List()
        {
            var model = ProductsRepository.Products;
            return View(model);
        }
    }
}