using Cansu.Core.DataAccess;
using Cansu.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cansu.Northwind.DataAccess.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}
