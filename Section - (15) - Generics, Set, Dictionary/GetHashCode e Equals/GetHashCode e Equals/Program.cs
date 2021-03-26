using System;
using GetHashCode_e_Equals.Entities;

namespace GetHashCode_e_Equals
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client1 = new Client("Maria", 99999999);
            Client client2 = new Client("Maria", 88888888);
            Client client3 = new Client("Alex", 77777777);

            Console.WriteLine(client1.Equals(client2));
            Console.WriteLine(client1.GetHashCode());
            Console.WriteLine(client2.GetHashCode());
            Console.WriteLine("------------------");
            Console.WriteLine(client1.Equals(client3));
            Console.WriteLine(client1.GetHashCode());
            Console.WriteLine(client3.GetHashCode());
        }
    }
}
