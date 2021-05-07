﻿using Cansu.Northwind.Business.Abstract;
using Cansu.Northwind.DataAccess.Abstract;
using Cansu.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cansu.Northwind.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetList();

        }
    }
}
