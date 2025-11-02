using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM
{
    public class Product(string name, decimal price, int quantity)
    {
        public string Name { get; set; } = name;
        public decimal Price { get; set; } = price;
        public int Quantity { get; set; } = quantity;
    }
}
