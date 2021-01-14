using System;
using SellProducts.Entities;
using System.Collections.Generic;

namespace SellProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> productList = new List<Product>(); 

            Console.Write("Enter the number of products: ");
            int productsAmount = int.Parse(Console.ReadLine());

            int productCount = 1;
            while (productCount <= productsAmount)
            {
                Console.WriteLine("Product #" + productCount + " data:");
                Console.Write("Common, used or imported (c/u/i)? : ");
                string productType = Console.ReadLine();

                Console.Write("Product name: ");
                string productName = Console.ReadLine();

                Console.Write("Product price: R$");
                double productPrice = double.Parse(Console.ReadLine());

                if (productType == "u")
                {
                    Console.Write("Product manufacture date (dd/mm/yyyy): ");
                    DateTime productDate = DateTime.Parse(Console.ReadLine());

                    Product product = new UsedProduct(productName, productPrice, productDate);
                    productList.Add(product);
                }

                if (productType == "i")
                {
                    Console.Write("Product custom fee: R$");
                    double productFee = double.Parse(Console.ReadLine());

                    Product product = new ImportedProduct(productName, productPrice, productFee);
                    productList.Add(product);
                }

                if (productType == "c")
                {
                    productList.Add(new Product(productName, productPrice));
                }

                productCount++;
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (Product products in productList)
            {
                Console.WriteLine(products.PriceTag());
            }



        }
    }
}
