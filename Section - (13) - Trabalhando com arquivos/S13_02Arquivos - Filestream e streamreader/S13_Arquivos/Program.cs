using System;
using System.IO;

namespace S13_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Udemy\C#\Section - (13) - Trabalhando com arquivos\S13_02Arquivos\Txts\s13_02.txt";

            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }

            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }

        }

    }
}

