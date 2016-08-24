using SportsStore.Mvc5.Domain.Abstract;
using SportsStore.Mvc5.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportsStore.Mvc5.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;

        public ProductController(IProductRepository productRepository)
        {
            repository = productRepository;
        }

        public ViewResult List()
        {
            return View(repository.Products);
        }
    }
}