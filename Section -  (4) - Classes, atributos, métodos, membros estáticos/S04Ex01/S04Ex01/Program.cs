using System;

namespace S04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y;

            x = new Pessoa();
            y = new Pessoa();

            Console.WriteLine("Dados da 1a pessoa. Digite o nome e a idade");

            x.Nome = Console.ReadLine();
            x.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da 2a pessoa. Digite o nome e a idade");

            y.Nome = Console.ReadLine();
            y.Idade = int.Parse(Console.ReadLine());

            if (x.Idade > y.Idade) {

                Console.WriteLine(x.Nome + "é a Pessoa Mais Velha");
            }
            else
            {
                Console.WriteLine(y.Nome + " é a Pessoa mais velha");
            }




        }
    }
}
