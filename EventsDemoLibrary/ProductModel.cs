using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDemoLibrary
{
    public class ProductModel
    {
        public decimal Price { get; private set; }
        public string Name { get; set; }
        public ProductModel(string name, decimal price)
        {
            Price = price;
            Name = name;
        }
    }
}
