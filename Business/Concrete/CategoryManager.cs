using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
   public class CategoryManager
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public Category GetById(int categoryId)
        {
            // bu kod aslında bunu arka planda yapar;
            //Selecet *from Categories where CategoryId=3;
            return _categoryDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
