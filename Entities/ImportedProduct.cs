using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Products.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() 
        {
        }

        public ImportedProduct(double customFee, string name, double price) : base(name, price)
        {
            CustomFee = customFee;
        }

        public double totalPrice()
        {
            return Price + CustomFee;
        }

        public override string priceTag()
        {
            string tag = $"{Name} $ {totalPrice()} (Customs fee: $ {CustomFee})";
            return tag;
        }
    }
}
