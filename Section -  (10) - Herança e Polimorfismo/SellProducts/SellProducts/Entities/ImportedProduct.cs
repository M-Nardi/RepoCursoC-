using System;
using System.Collections.Generic;
using System.Text;

namespace SellProducts.Entities
{
    class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customFee) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double TotalPrice()
        {
            double totalPrice = Price + CustomFee;
            return totalPrice;
        }

        public override string PriceTag()
        {
            return Name + " R$" + TotalPrice().ToString("F2") + " (Custom Fee: R$" + CustomFee.ToString("F2") + ")";
        }


    }
}
