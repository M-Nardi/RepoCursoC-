using System;
using System.Collections.Generic;
using HashSet_Contains_Equals_e_Hashcode.Entities;

namespace HashSet_Contains_Equals_e_Hashcode
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();

            HashSet<Point> b = new HashSet<Point>();

            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));
           
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            //caso nao implementado o método equals e hashcode na classe, retornará false.
            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            //no caso, struct utilizara as variaveis da classe para a comparação e não o endereço de referencia, portanto não é necessário a implementação do equals e hashcode neste caso.
            Point point = new Point(5, 10);
            Console.WriteLine(b.Contains(point));
        }
    }
}