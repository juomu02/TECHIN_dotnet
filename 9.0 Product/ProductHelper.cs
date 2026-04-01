namespace Products
{
    public class ProductHelper
    {
        public static Product MostExpensive(List<Product> products)
        {
            var mostExpensiveProduct = products[0];
            foreach (var product in products)
            {
                if (product.Price > mostExpensiveProduct.Price)
                {
                    mostExpensiveProduct = product;
                }
            }

            return mostExpensiveProduct;
        }
        public static Product MostExpensive(List<Product> products, double maxPrice)
        {
            var filteredList = products.Where(o => o.Price <= maxPrice).ToList();
            return MostExpensive(filteredList); //Ar šitą išeina parašyti per :this(...)?  Man nepavyko.          
        }
    }
}
