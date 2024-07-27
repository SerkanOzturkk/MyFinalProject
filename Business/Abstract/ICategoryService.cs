using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        //Dış dünyaya servis etmek istediklerimiz
        List<Category> GetAll();
        Category GetById(int categoryId);


    }
}
