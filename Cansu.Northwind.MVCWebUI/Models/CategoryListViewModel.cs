using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cansu.Northwind.Entities.Concrete;

namespace Cansu.Northwind.MVCWebUI.Models
{
    public class CategoryListViewModel
    {
        public List<Category> Categories { get; internal set; }
        public int CurrentCategory { get; internal set; }
    }
}
