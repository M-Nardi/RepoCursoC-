using System;
using System.Collections.Generic;
using System.Text;

namespace GetHashCode_e_Equals.Entities
{
    class Client
    {
        public string Name { get; set; }
        public int Cpf { get; set; }

        public Client(string name, int cpf)
        {
            Name = name;
            Cpf = cpf;
        }

        public override bool Equals(object obj)
        {
            Client other = obj as Client;

            return Name.Equals(other.Name);
        }


        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
