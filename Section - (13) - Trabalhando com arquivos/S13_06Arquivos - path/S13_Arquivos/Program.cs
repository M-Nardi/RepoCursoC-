using System;
using System.IO;

namespace S13_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {

            string sourcePath = @"D:\Udemy\C#\Section - (13) - Trabalhando com arquivos\S13_04Arquivos - streamWriter\Txts\s13_04.txt";
            string targetPath = @"D:\Udemy\C#\Section - (13) - Trabalhando com arquivos\S13_04Arquivos - streamWriter\Txts\s13_04out.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }


                }


            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
           
            }

        }

    }
}

