using System;

namespace S06_Ex02AulaMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Números de linhas: ");
            int linha = int.Parse(Console.ReadLine());
            Console.Write("Números de coluna: ");
            int coluna = int.Parse(Console.ReadLine());


            int[,] matriz = new int[linha, coluna];

            Console.WriteLine("Digite os numeros separados por espaço");


            for (int i = 0; i < linha; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');

                for (int j = 0; j < coluna; j++)
                {

                    matriz[i, j] = int.Parse(valores[j]);

                }
            }

            Console.Write("Digite um número que se encontre na matriz para encontrar seus vizinhos: ");
            int acharNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {

                    if (matriz[i,j] == acharNum)
                    {
                        Console.WriteLine("Position: " + i + "," + j);

                        if (j > 0) {
                            Console.WriteLine("Left: " + matriz[i, (j - 1)]);
                        }
                        if (j < coluna - 1)
                        {
                            Console.WriteLine("Right: " + matriz[i, (j + 1)]);
                        }
                        if (i < linha - 1)
                        {
                            Console.WriteLine("Down: " + matriz[(i + 1), j]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + matriz[(i - 1), j]);
                        }

                    }

                }

            }
        }
    }
}
