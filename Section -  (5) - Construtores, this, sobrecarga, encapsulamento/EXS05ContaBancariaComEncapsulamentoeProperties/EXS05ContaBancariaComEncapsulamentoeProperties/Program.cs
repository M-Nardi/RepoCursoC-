using System;

namespace EXS05ContaBancariaComEncapsulamentoeProperties
{
    class Program
    {
        static void Main(string[] args)
        {

    

            Console.Write("Entre com o nome do Titular da conta: ");
            string titularConta = (Console.ReadLine());


            Console.Write("Entre com o Número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());


            Console.Write("Haverá depósito inicial? (s/n)? : ");
            char temDeposito = char.Parse(Console.ReadLine());

            Console.WriteLine("");

            double retorno_deposito = ContaBancaria.TemDeposito(temDeposito);
            ContaBancaria conta1 = new ContaBancaria(titularConta, numeroConta, retorno_deposito);
            
            Console.WriteLine(conta1);

            Console.WriteLine("");

            Console.Write("Entre com um valor para depósito: R$ ");
            double valorDeposito = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            conta1.DepositarDinheiro(valorDeposito);
            Console.WriteLine(conta1);

            Console.WriteLine("");


            Console.Write("Entre com um valor para sacar: R$ ");
            double valorSaque = double.Parse(Console.ReadLine());


            Console.WriteLine("");

            conta1.SacarDinheiro(valorSaque);
            Console.WriteLine(conta1);

            Console.WriteLine("");



        }
    }
}
