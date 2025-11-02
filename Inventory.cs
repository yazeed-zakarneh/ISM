using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISM
{
    public class inventory
    {
        private List<Product> products;

        public inventory()
        {
            products = new List<Product>();
        }


        public void AddProduct(string name, decimal price, int quantity)
        {
            products.Add(new Product(name, price, quantity));
        }

        public string ViewAllProducts()
        {
            string allProducts = string.Empty;
            foreach (Product product in products)
            {
                allProducts += $"Product Name: {product.Name}, Price: {product.Price}, Quantity: {product.Quantity} /n";
            }

            return allProducts;
        }

    };
}
