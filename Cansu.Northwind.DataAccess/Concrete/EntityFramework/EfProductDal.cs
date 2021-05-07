using Cansu.Core.DataAccess.EntityFramework;
using Cansu.Northwind.DataAccess.Abstract;
using Cansu.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cansu.Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
