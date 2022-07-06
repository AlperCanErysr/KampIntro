using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 123;
            product1.CategoryId = 2;
            product1.ProductName = "Computer";
            product1.UnitPrice = 20000;
            product1.UnitsInStock = 50;{};

            Product product2 = new Product { Id = 2, CategoryId   =5,UnitsInStock=5,ProductName="Phone",UnitPrice=10000 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


        }
    }
}
