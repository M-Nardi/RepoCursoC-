using System;

namespace S04EXNotaAluno
{
    class Program
    {
        static void Main(string[] args)
        {

            Aluno aluno1;

            aluno1 = new Aluno();

            Console.Write("Insira a primeira nota:");
            aluno1.N1 = double.Parse(Console.ReadLine());

            Console.Write("Insira a segunda nota:");
            aluno1.N2 = double.Parse(Console.ReadLine());

            Console.Write("Insira a terceira nota:");
            aluno1.N3 = double.Parse(Console.ReadLine());

            aluno1.NotaFinal();
        }
    }
}
