using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex_Generic_com_IComparable.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("Not possible to compare this object with a Product type variable");
            }
            Product other = obj as Product;

            return Price.CompareTo(other.Price);

        }
    }
}
