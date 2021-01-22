using System;
using System.IO;

namespace S13_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Udemy\C#\Section - (13) - Trabalhando com arquivos\S13_03Arquivos - bloco using\Txts\s13_02.txt";


            try
            {
                using (StreamReader sr = File.OpenText(path))

                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
              
                }
            }

            catch(IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

        }

    }
}

