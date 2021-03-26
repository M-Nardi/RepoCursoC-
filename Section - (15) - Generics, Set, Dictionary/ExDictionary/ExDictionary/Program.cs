using System;
using System.IO;
using System.Collections.Generic;
//D:\Udemy\C#\Section - (15) - Generics, Set, Dictionary\ExDictionary\info.txt

namespace ExDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> data = new Dictionary<string, int>();

            Console.WriteLine("Insert .txt path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(",");
                        string candidate = line[0];
                        int value = int.Parse(line[1]);
                        
                        if (data.ContainsKey(candidate))
                        {
                            data[candidate] += value;
                        }
                        else
                        {
                            data[candidate] = value;
                        }

                    }
                }

                foreach (KeyValuePair<string, int> obj in data)
                {
                    Console.WriteLine("Name: " + obj.Key + " and Votes: " + obj.Value);
                }

            }

            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
    

