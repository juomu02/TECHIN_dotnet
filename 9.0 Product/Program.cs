namespace Products
{
    public class Task9
    {
        public static void Main()
        {
            var product = new Product("Koldūnas", 11, 0.18);
            Console.WriteLine($@"Produkto pavadinimu ""{product.Name}"" visa vertė yra {product.TotalValue}.");
        }
    }
}


