namespace Products
{
    public class Task9
    {
        public static void Main()
        {
            //3.b
            PrintSeveralProductValues();

            //5.a
            var productList = CreateProductList();
            //5.b
            PrintProductList(productList);
            //5.d
            PrintProductCount();


        }
        public static void PrintSeveralProductValues()
        {
            var product = new Product("Koldūnas", 11, 0.18);
            var product2 = new Product("Makaronas", 15, 0.02);
            var product3 = new Product("Pipiras", 215, 0.01);
            Console.WriteLine($"3.b Iš viso sukurti {Product.ProductCount} produktas(-ai).");
            Console.WriteLine();
        }
        public static List<Product> CreateProductList()
        {
            return new List<Product>
            {
                 new Product("Koldūnas", 11, 0.18),
                 new Product("Makaronas", 15, 0.02),
                 new Product("Pipiras", 215, 0.01),
                 new Product("Česnakas", 45, 0.45),
                 new Product("Apelsinas", 5, 0.60)
            };
        }

        public static void PrintProductList(List<Product> productList)
        {
            Console.WriteLine("5.b užduoties produktų sąrašas:");
            Console.WriteLine("Pavadinimas\tKaina\tKiekis\tVertė");
            foreach (var product in productList)
            {
                //5.c
                Console.WriteLine($"{product.Name}\t{product.Price}\t{product.Quantity}\t{product.TotalValue}");
            }
            Console.WriteLine();
        }

        public static void PrintProductCount()
        {
            Console.WriteLine($"5.d Visų produktų bendra suma: {Product.ProductCount}");
            Console.WriteLine();
        }
    }
}


