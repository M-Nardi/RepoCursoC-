using System;
using System.Collections.Generic;
using System.Text;

namespace HashSet_Contains_Equals_e_Hashcode.Entities
{
    class Product
     {
         public string Name { get; set; }
         public double Price { get; set; }
         public Product(string name, double price)
         {
            Name = name;
            Price = price;
         }

        public override bool Equals(object obj)
        {
            Product other = obj as Product;

            return Name.Equals(other.Name) && Price.Equals(other.Price);

        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

    }
}
