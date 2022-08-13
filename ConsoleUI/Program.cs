using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
namespace ConsoleUI {
    class Program {
        static void Main(string[] args)
        {
            productTest();
            categoryTest();
        }
        private static void productTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            }

        }
        private static void categoryTest()
        {
            Console.WriteLine("Kategoriler->");
            CategoryManager categoryanager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryanager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

        }
    }

}
