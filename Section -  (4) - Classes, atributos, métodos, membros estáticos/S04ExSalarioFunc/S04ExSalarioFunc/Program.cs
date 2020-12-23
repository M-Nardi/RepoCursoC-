using System;

namespace S04ExSalarioFunc
{
    class Program
    {
        static void Main(string[] args)
        {

            Funcionario func1;
            func1 = new Funcionario();

            Console.Write("Digite o nome do funcionário:");

            func1.Nome = Console.ReadLine();

            Console.Write("Digite o salário do funcionário R$:");

            func1.Salario = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do imposto R$:");

            func1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + func1.Nome + ", R$" + func1.SalarioLiquido());

            Console.Write("Digite a porcentagem para aumentar o salário:");

            double porcentagem = double.Parse(Console.ReadLine());

            func1.AumentarSalario(porcentagem);

            Console.WriteLine(func1);







        }
    }
}
