using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using Ex_Generic_com_IComparable.Entities;
using Ex_Generic_com_IComparable.Services;

namespace Ex_Generic_com_IComparable
{
    class Program
    {
        static void Main(string[] args)
        {

            List <Product> productList = new List<Product>();

            Console.Write("Insert number of products: ");
            int amountProducts = int.Parse(Console.ReadLine());

            int cont = 1;

            while (cont <= amountProducts)
            {
                Console.Write("Product #" + cont + ":");
                string[] productInfo = Console.ReadLine().Split(",");

                string productName = productInfo[0];
                double productPrice = double.Parse(productInfo[1], CultureInfo.InvariantCulture);

                productList.Add(new Product(productName, productPrice));

                cont++;
            }

            CalculationService calculationService = new CalculationService();

            Product max = calculationService.Max(productList);

            Console.Write("Product wich costs more: ");
            Console.WriteLine(max);

            
        }
    }
}
