// See https://aka.ms/new-console-template for more information

using Business.Concrete;
using Business.Test;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TestProduct testProduct = new TestProduct();
            //ProductTest();
            //CategoryAllTest.CategoryTest();
            //testProduct.GetAll();
            //testProduct.GetByID(1);
            //testProduct.Add(new Product{CategoryId = 1,ProductName = "test1",UnitPrice = 250,UnitsInStock = 10});
            //testProduct.Update(new Product { ProductId = 78,CategoryId = 1, ProductName = "test2", UnitPrice = 250, UnitsInStock = 10 });
            //testProduct.Delete(new Product { ProductId = 78});
            //testProduct.GetProductDetails();
            //testProduct.GetByUnitPrice(1,10);
            testProduct.GetAllByCategoryId(1);



        }

        public static class CategoryAllTest
        {
            public static void CategoryTest()
            {
                CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

                var result = categoryManager.GetAll();

                if (result.Success == true)
                {
                    foreach (var category in result.Data)
                    {
                        Console.WriteLine(category.CategoryId + "/" + category.CategoryName);
                    }
                }
                else
                {
                    Console.WriteLine(result.Message);
                }
            }
        }

    }
}


