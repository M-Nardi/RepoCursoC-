using System;

namespace S04ExConversor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Qual a cotação do dólar atual? R$:");

            double cotacao = double.Parse(Console.ReadLine());

            Console.Write("Quantos dólares você vai comprar? R$:");

            double qtdDolar = double.Parse(Console.ReadLine());

            double valorConvertido = ConversorDeMoeda.ConverterMoeda(cotacao, qtdDolar);

            Console.WriteLine("Valor a ser pago em reais = R$" + valorConvertido);
        }
    }
}
