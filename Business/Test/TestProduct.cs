using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace Business.Test
{
    public  class TestProduct : ITest
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        public void GetAll()
        {
            var result = productManager.GetAll();



            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductId + " -  " + product.ProductName + " -  " + product.CategoryId
                                      + " -  " + product.UnitPrice + " -  " + product.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void GetByID(int Id)
        {
            var result = productManager.GetById(Id);

            if (result.Success == true)
            {
                var product = result.Data;
                Console.WriteLine(product.ProductId + " -  " + product.ProductName + " -  " + product.CategoryId
                                  + " -  " + product.UnitPrice + " -  " + product.UnitsInStock);
                
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void Add(Product product)
        {
            var result = productManager.Add(product);

            if (result.Success == true)
            {
                GetAll();
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void Update(Product product)
        {
            var result = productManager.Update(product);

            if (result.Success == true)
            {
                GetAll();
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void Delete(Product product)
        {
            var result = productManager.Delete(product);

            if (result.Success == true)
            {
                GetAll();
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        public void GetAllByCategoryId(int categoryId)
        {
            var result = productManager.GetAllByCategoryId(categoryId);

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductId + " -  " + product.ProductName + " -  " + product.CategoryId
                                      + " -  " + product.UnitPrice + " -  " + product.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        public void GetByUnitPrice(decimal min,decimal max)
        {
            var result = productManager.GetByUnitPrice(min,max);

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductId + " -  " + product.ProductName + " -  " + product.CategoryId
                                      + " -  " + product.UnitPrice + " -  " + product.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        public void GetProductDetails()
        {
            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductId + " -  " + product.ProductName + " -  " + product.CategoryName
                                      + " -  " + product.UnitsInStock);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
