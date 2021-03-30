using System;
using System.Collections.Generic;
using Exemplos_RemoveAll_Foreach_Select.Entities;
using System.Linq;

namespace Exemplos_RemoveAll_Foreach_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            //Predicate representa um método que recebe um objeto do tipo T e retorna um valor booleano

            //public delegate bool Predicate<in T>(T obj);
            
            //Fazer um programa que, a partir de uma lista de produtos, remova da lista somente aqueles cujo preço seja 700 ou menos.
            
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(RemoveProduct);

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine("//----FIM EXEMPLO PREDICATE REMOVEALL. removido produtos de 700 para baixo----");
            Console.WriteLine();

            //------------------------------------------------------------------------------------------------------------------------------------------

            //Action  representa um método void que recebe zero ou mais argumentos

            //public delegate void Action();
            //public delegate void Action<in T>(T obj);
            //public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2); e assim sucessivamente até 16 args.

            //Fazer um programa que, a partir de uma lista de produtos, aumente o preço dos produtos em 10 %.

            list.ForEach(RaiseProductPrice);

            // ou podemos fazer da seguinte forma:
            //Action<Product> act = RaiseProductPrice;
            //list.Foreach(act);

            //podemos também utilizar funcao lambda diretamente como no exemplo abaixo sem precisar construir um método
            //Action<Product> act = p => {p.Price+= p.Price * 0.1; };
            //list.Foreach(act);

            //podemos colocar a funcao lambda diretamente no forEach
            //list.Foreach(p => {p.Price+= p.Price * 0.1; });

            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine("//----FIM EXEMPLO ACTION FOREACH. aumentado o preço dos produtos em 10%----");
            Console.WriteLine();


            //------------------------------------------------------------------------------------------------------------------------------------------

            //Func representa um método que recebe zero ou mais argumentos, e retorna um valor

            //public delegate TResult Func<out TResult>();
            //public delegate TResult Func<in T, out TResult>(T obj);
            //public delegate TResult Func<in T1, in T2, out TResult>(T1 arg1, T2 arg2); e assim sucessivamente até 16 args.

            //Fazer um programa que, a partir de uma lista de produtos, gere uma nova lista contendo os nomes dos produtos em caixa alta.

            
            List<string> result = list.Select(ProductNameToUpper).ToList();

            //ou

            //Func<Product, string> func = ProductNameToUpper;
            //List<string> result = list.Select(func).ToList();

            foreach (string p in result)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
            Console.WriteLine("//----FIM EXEMPLO FUNC SELECT. criado nova lista com nomes toupper----");
            Console.WriteLine();


        }



        public static bool RemoveProduct(Product p)
        { //Funcao do predicate removeAll
            return p.Price >= 700;
        }


        public static void RaiseProductPrice(Product p)
        {//Funcao do action forEach
            p.Price += p.Price * 0.1;
        }

        public static string ProductNameToUpper(Product p)
        {//Funcao Func Select
            return p.Name.ToUpper();
        }

    }
}
