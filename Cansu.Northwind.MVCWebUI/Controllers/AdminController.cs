using Cansu.Northwind.Business.Abstract;
using Cansu.Northwind.Entities.Concrete;
using Cansu.Northwind.MVCWebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cansu.Northwind.MVCWebUI.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;

        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var productListViewModel = new ProductListViewModel
            {
                Products = _productService.GetAll()
        };
            return View(productListViewModel);
        }

        public IActionResult Add()
        {
            var model = new ProductAddViewModel
            {
                Product = new Product(),
                Categories = _categoryService.GetAll()
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Add(product);
                TempData.Add("message", String.Format("Product was successfully added."));
            }
            return RedirectToAction("Add");
            
        }

        public IActionResult Update(int productId)
        {
            var model = new ProductUpdateViewModel{
                Product = _productService.GetById(productId),
                Categories = _categoryService.GetAll()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Product product)
        {
            if (ModelState.IsValid)
            {
                _productService.Update(product);
                TempData.Add("message", String.Format("Product was successfully updated."));
            }
            return RedirectToAction("Update");
        }

        public IActionResult Delete(int productId)
        {
            _productService.Delete(productId);
            TempData.Add("message", String.Format("Product was successfully deleted."));
            return RedirectToAction("Index");

        }
    }
}
