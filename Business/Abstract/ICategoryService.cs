using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //Dış dünyaya servis etmek istediklerimiz

        IDataResult<List<Category>> GetAll();
        IDataResult<Category> GetById(int categoryId);
        IResult Add(Category category);
        IResult Update(Category category);
        IResult Delete(Category category);


    }
}
