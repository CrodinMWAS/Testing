namespace ShoppingCartProject.Models
{
    public class ShoppingCart
    {
        private readonly List<Product> _products;

        public ShoppingCart()
        {
            _products = new List<Product>();
        }

        public int ProductCount => _products.Count;

        //TODO Készítse el a ShoppingCart osztályban azokat a metódusokat, amelyekkel sikeresen lefutnak a tesztesetek!

        public void AddProduct(string product, double price)
        {
            Product newProduct = new(product, price);
            _products.Add(newProduct);
        }

        public void RemoveProduct(string productName)
        {
            if (!_products.Any(x => x.Name == productName))
            {
                throw new InvalidOperationException("Product not in cart.");
            }

            for (int i = 0; i != _products.Count; i++)
            {
                Product product = _products[i];
                if (product.Name == productName)
                {
                    _products.Remove(product);
                }
            }
        }

        public double GetTotalPrice()
        {
            double total = 0;
            foreach (Product product in _products)
            {
                total += product.Price;
            }
            return total;
        }

        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
