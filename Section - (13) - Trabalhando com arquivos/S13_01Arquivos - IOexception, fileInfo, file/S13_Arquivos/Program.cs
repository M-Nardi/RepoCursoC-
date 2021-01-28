using System;
using System.IO;

namespace S13_Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\Udemy\C#\Section - (13) - Trabalhando com arquivos\S13_Arquivos\Txts\s13_01.txt";
            string targetPath = @"D:\Udemy\C#\Section - (13) - Trabalhando com arquivos\S13_Arquivos\Txts\s13_01out.txt";
            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred" + e);
            }



        }
    }
}
