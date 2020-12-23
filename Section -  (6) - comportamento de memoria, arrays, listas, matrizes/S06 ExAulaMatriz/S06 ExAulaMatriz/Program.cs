using System;

namespace S06_ExAulaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número N para gerar uma matriz de ordem N");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            Console.WriteLine("Digite os números a serem incluidos na matriz separado por espaço");

            for (int i = 0; i < n; i++)
            {

                string[] valores = Console.ReadLine().Split(' ');

                for (int x = 0; x < n; x++)
                {
                    matriz[i, x] = int.Parse(valores[x]);
                }
            }

            Console.WriteLine("Diagonal Principal:");
            for (int j = 0; j < n; j++)
            {
                int diagonal = matriz[j, j];
                Console.Write(diagonal + " ");
            }

            int cont = 0;
            Console.WriteLine();
            
            for (int i = 0; i < n; i++)
            {

                for (int x = 0; x < n; x++)
                {

                    if (matriz[i, x] <= -1)
                    {
                        cont++;
                    }

                }
            }

            Console.WriteLine("Numeros negativos: " + cont);

        }
    }
}
