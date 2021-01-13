using System;
using ExemploHeranca.Entities;
namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {

            //Para que selar as classes?   

            //Segurança: Dependendo das regras do negócio as vezes é desejavel garantir que uma classe não seja herdada, ou que um metodo nao seja sobreposto
            //Geralmente convem selar metodos sobrepostos pois sobreposicoes multiplas pode ser uma porta de entrada para inconcistencias

            //Performance: Atributos tipados de uma classe selada sao analisados de forma mais rapida em tempo de execucao. ex:(string)

            Account acc1 = new Account(1001, "Alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);
            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);
            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);

        }
    }
}
