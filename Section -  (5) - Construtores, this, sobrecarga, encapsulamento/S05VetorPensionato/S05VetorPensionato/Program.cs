using System;
using System.Globalization;

namespace S05VetorPensionato
{
    class Program
    { 
        static void Main(string[] args)
        {
            int numeroQuartos = 10;

            Pensionato[] quarto = new Pensionato[numeroQuartos];

            Console.Write("How many rooms will be rented? ");
            int qtdeAlunos = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int n = 0; n < qtdeAlunos; n++)
            {
                int rentNumber = n + 1;
                Console.WriteLine("Rent #" + rentNumber + ":");
                Console.Write("Name: ");
                string nomeAluno = Console.ReadLine();
                Console.Write("Email: ");
                string emailAluno = Console.ReadLine();
                Console.Write("Room: ");
                int quartoAluno = int.Parse(Console.ReadLine());

                quarto[quartoAluno] = new Pensionato { EmailEstudante = emailAluno, NomeEstudante = nomeAluno, NumeroQuarto = quartoAluno };
                Console.WriteLine("");
            }

            Console.WriteLine("Busy Rooms");

            for (int n = 0; n < numeroQuartos; n++)
            {   
                if (quarto[n] != null)
                Console.WriteLine(quarto[n]);
            }

            //foreach ( Object obj in quarto)
            //{
            // Console.WriteLine(obj);
            //}




        }
    }
}
