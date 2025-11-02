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

        public Product? SearchProduct(string name)
        {
            
            foreach (Product product in products)
            {
                if(product.Name == name)
                {
                    return product;
                } 
            }

            return null;
        }

        public void EditProduct(string currentName,  string name, decimal price, int quantity)
        {
            Product? getProduct = SearchProduct(currentName);
            if (getProduct!= null)
            {
                getProduct.Name = name;
                getProduct.Price = price;
                getProduct.Quantity = quantity;
            }
        }

        public void DeleteProduct (string name)
        {
            Product? product = SearchProduct(name);
            if(product!=null)
            {
                products.Remove(product);
            }
        }


    };
}
