using System;
using System.Collections.Generic;
using System.IO;
using ExConjuntoLogUsuarios.Entities;

namespace ExConjuntoLogUsuarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //conteudo .txt
            //amanda 2020-08-26T20:45:08
            //alex86 2020-08-26T21:49:37
            //bobbrown 2020-08-27T03:19:13
            //amanda 2020-08-27T08:11:00
            //jeniffer3 2020-08-27T09:19:24
            //alex86 2020-08-27T22:39:52
            //amanda 2020-08-28T07:42:19
            

            //como a ordem não é de extrema importancia usaremos hashset ao invés de sortedset
            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file .txt path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime moment = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Moment = moment });
                    }

                    Console.WriteLine("HashSet print after filtering equal users: ");
                    foreach (LogRecord data in set)
                    {
                        Console.WriteLine(data.Username + " " + data.Moment);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Total users: " + set.Count);
                }
            }
            catch (IOException e) { 
                Console.WriteLine(e.Message);
            }

        }
    }
}


