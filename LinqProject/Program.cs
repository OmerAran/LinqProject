using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1 , CategoryName="Elektronik"},
                new Category{CategoryId=2 , CategoryName="Moda"},

            };

            List<Product> products = new List<Product>
            {
                new Product {ProductId=1 ,ProductName="Laptop",UnitPrice=9000,UnitInStock=100,CategoryId=1,QuantityPerUnit="16 GB RAM , 500GB SSD"},
                new Product {ProductId=2 ,ProductName="Telefon",UnitPrice=5000,UnitInStock=200,CategoryId=1,QuantityPerUnit="8 GB RAM , 500GB Dahili depolama"},
                new Product {ProductId=3 ,ProductName="Powerbank",UnitPrice=200,UnitInStock=300,CategoryId=1,QuantityPerUnit="40000 mAh"},
                new Product {ProductId=4 ,ProductName="kaban",UnitPrice=490,UnitInStock=1000,CategoryId=2,QuantityPerUnit="Zara"},
                new Product {ProductId=5 ,ProductName="bot",UnitPrice=900,UnitInStock=10000,CategoryId=2,QuantityPerUnit="Bershka"},
            };
                          // ALGORİTMİK YAZILIŞ 
            //foreach (var product in products)
            //{
            //    if (product.UnitPrice>500 && product.UnitInStock>150)
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }
            //}


            // LİNQ İLE YAZILIŞ
            var result =products.Where(p=>p.UnitPrice>500 && p.UnitInStock>150); // bu şekilde olucak ancak biz ekranda göstermek için foreach kullanalım yine.
            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

        }

        static List<Product> GetProducts(List<Product> products)
        {
            return  products.Where(p => p.UnitPrice > 500 && p.UnitInStock > 150).ToList();
        }

      
    }
}
