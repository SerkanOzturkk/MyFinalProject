using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;
using Entities.Concrete;

namespace Business.Test
{
    public interface ITest
    {
        void GetAll();
        void GetByID(int Id);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

    }
}
