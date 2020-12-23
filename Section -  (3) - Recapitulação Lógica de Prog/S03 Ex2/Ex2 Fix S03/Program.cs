using System;
using System.Globalization;

namespace Ex2_Fix_S03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem a sua casa? :");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto em R$:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite seu nome, idade e altura (mesma linha) :");
            string[] vet = Console.ReadLine().Split(" ");

            string nomevet = vet[0];

            int idadevet = int.Parse(vet[1]);

            double alturavet = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);

            Console.WriteLine(quarto);

            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(nomevet);

            Console.WriteLine(idadevet);

            Console.WriteLine(alturavet.ToString("F2", CultureInfo.InvariantCulture));
                

        }
    }
}
