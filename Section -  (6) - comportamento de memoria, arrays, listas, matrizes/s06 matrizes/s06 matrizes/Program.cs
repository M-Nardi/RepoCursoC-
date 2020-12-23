using System;

namespace s06_matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine(mat.Length); // qtd dee elementos que podem seer alocados na matriz

            Console.WriteLine(mat.GetLength(0)); // pega tamanho da 1a dimensão

            Console.WriteLine(mat.GetLength(1)); // pega tamanho da 2a dimensão

            Console.WriteLine(mat.Rank); //qtd linhas da 1a dimensão



        }
    }
}
