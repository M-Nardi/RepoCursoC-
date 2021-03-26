using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Exemplo1.Services;

namespace Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;

            Console.Write("How many values? : ");
            int amountValues = int.Parse(Console.ReadLine());

            PrintService<int> list = new PrintService<int>();

            while (cont < amountValues)
            {
                int number = int.Parse(Console.ReadLine());

                list.AddValue(number);

                cont++;
            }

            list.Print();
            Console.WriteLine("First: " + list.First());

        }
    }
}
