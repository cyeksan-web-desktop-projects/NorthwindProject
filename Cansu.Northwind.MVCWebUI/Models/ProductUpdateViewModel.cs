using Cansu.Northwind.Entities.Concrete;
using System.Collections.Generic;

namespace Cansu.Northwind.MVCWebUI.Models
{
    public class ProductUpdateViewModel
    {
        public Product Product { get; set; }
        public List<Category> Categories { get; set; }
    }
}