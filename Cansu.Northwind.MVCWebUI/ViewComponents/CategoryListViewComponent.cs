using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cansu.Northwind.Business.Abstract;
using Cansu.Northwind.MVCWebUI.Models;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace Cansu.Northwind.MVCWebUI.ViewComponents
{
    public class CategoryListViewComponent:ViewComponent
    {
        ICategoryService _categoryService;

        public CategoryListViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ViewViewComponentResult Invoke()
        {
            var categories = _categoryService.GetAll();

            CategoryListViewModel model = new CategoryListViewModel
            {
                Categories = categories,
                CurrentCategory = Convert.ToInt32(HttpContext.Request.Query["category"])
            };
            return View(model);
        }
    }
}
