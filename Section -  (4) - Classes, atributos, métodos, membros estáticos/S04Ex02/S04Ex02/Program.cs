using System;

namespace S04Ex02
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario p1, p2;

            p1 = new Funcionario();
            p2 = new Funcionario();


            Console.WriteLine("dados da primeira pessoa");

            p1.Nome = Console.ReadLine();
            p1.Salario = double.Parse(Console.ReadLine());

            Console.WriteLine("dados da primeira pessoa");

            p2.Nome = Console.ReadLine();
            p2.Salario = double.Parse(Console.ReadLine());

            double salarioMedio = (p1.Salario + p2.Salario) / 2;

            Console.WriteLine("O salário médio dos funcionários " + p1.Nome + " e " + p2.Nome + " é de R$:" + salarioMedio);


        }
    }
}
