using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constanst;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //İş kodları
            //Gerekli şartlar sağlanırsa return
            if (DateTime.Now.Hour == 21)
            {
                return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
            }

            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.ProductsListed);
        }


        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryId == categoryId));
        }

        public IResult Add(Category product)
        {
            //business codes

            if (product.CategoryName.Length < 2)
            {
                return new ErrorResult(Messages.ProductNameInvalid);
            }
            _categoryDal.Add(product);

            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);

            return new SuccessResult(Messages.ProductUpdated);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);

            return new SuccessResult(Messages.ProductDeleted);
        }

    }
}
