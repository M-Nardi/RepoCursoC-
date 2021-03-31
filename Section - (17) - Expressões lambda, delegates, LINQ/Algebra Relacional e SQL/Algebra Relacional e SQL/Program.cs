using System;
using System.Linq;
using System.Collections.Generic;
using Algebra_Relacional_e_SQL.Entities;

namespace Algebra_Relacional_e_SQL
{
    class Program
    {

        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            //var r1 = products.Where(p => p.Price < 900 && p.Category.Tier == 1);
            var r1 =
                from p in products
                where p.Price < 900 && p.Category.Tier == 1
                select p;
            Print("Tier 1 and price < 900: ", r1);



            //var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            var r2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("Name of products that are in tools category: ", r2);



            //colocado um alias CategoryName
            //var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name }); //necessário new para selecionar conjunto de infos
            var r3 =
                from p in products
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    categoryName = p.Category.Name
                };
            Print("Products that the first letter is C (name, price and category name): ", r3);



            //var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name); //ordenação
            var r4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Price, p.Name
                select p;
            Print("products that are in the first Tier // ordenate by price then name: ", r4);



            //var r5 = r4.Skip(2).Take(4);//skip e take
            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);
            Print("r4 result, skip first 2 products then take the next 4 products: ", r5);



            //var r6 = products.First();//first
            var r6 =
            (from p in products
             select p).First();

            Console.WriteLine("First product of products list: " + r6);
            Console.WriteLine();


            //var r7 = products.Where(p => p.Price > 3000).FirstOrDefault(); //first or default -> não funciona caso o where retorne mais de um elemento.
            var r7 =
                (from p in products
                 where p.Price > 3000.0
                 select p).FirstOrDefault();

            Console.WriteLine("There are no products that worth more than 3000, so, if we use '.First' instead '.FirstOrDefault()' will cause one exception: " + r7);
            Console.WriteLine();


            //var r8 = products.Where(p => p.Id == 3).SingleOrDefault(); //irá retornar o ID se existir, ou nulo caso nao exista
            var r8 =
                (from p in products
                 where p.Id == 3
                 select p).SingleOrDefault();
            
            Console.WriteLine("Returning product that corresponds to the ID // single or default test: " + r8);
            Console.WriteLine();


            //var r9 = products.Where(p => p.Id == 24).SingleOrDefault();//irá retornar o ID se existir, ou nulo caso nao exista
            var r9 =
                (from p in products
                 where p.Id == 25
                 select p).SingleOrDefault();

            Console.WriteLine("Returning product that corresponds to the ID // single or default test: " + r9);
            Console.WriteLine();


            if (r9 == null) Console.WriteLine("ID Nulo");
            Console.WriteLine();


            //var r10 = products.Max(p => p.Price); //max valor
            var r10 =
                (from p in products
                 select p.Price).Max();
            Console.WriteLine("Max price:" + r10);
            Console.WriteLine();


            //var r11 = products.Min(p => p.Price); //min valor
            var r11 =
                (from p in products
                 select p.Price).Min();
            Console.WriteLine("Min price:" + r11);
            Console.WriteLine();


            //var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price); //funcao soma
            var r12 =
                (from p in products
                 where p.Category.Id == 1
                 select p.Price).Sum();
            Console.WriteLine("price sum of the first category products: " + r12);
            Console.WriteLine();


            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price); //funcao media, se valor for 0, vai dar erro, divisao por 0
            Console.WriteLine("average price of the first category products: " + r13);
            Console.WriteLine();


            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average(); //protecao para que nao ocorra divisao por 0, transformar em conjuntos de preco e dps fazer a media.
            Console.WriteLine("average price of category that don't have products: " + r14);
            Console.WriteLine();


            //Select e Aggregate -> é possivel fazer operacoes personalizadas com lambda como no exemplo abaixo
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate((x, y) => x + y); //método de soma personalizado
            Console.WriteLine("price sum of the first category products (aggregate method): " + r15);
            Console.WriteLine();


            var r16 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y); //no exemplo acima, caso não tenha elementos para soma, daria exception. Definimos antes da expressão um valor padrão antes da soma.
            Console.WriteLine("price sum of the first category products (aggregate method): " + r16);
            Console.WriteLine();


            //GROUP BY CATEGORY
            //var r17 = products.GroupBy(p => p.Category);
            var r17 =
                from p in products
                group p by p.Category;
            Console.WriteLine("GroupBy category: ");
            Console.WriteLine();
            foreach (IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach (Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();



            }

        }

    }
}