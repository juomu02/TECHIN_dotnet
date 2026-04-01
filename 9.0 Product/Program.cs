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

            //6.a
            var mostExpensiveProduct = ProductHelper.MostExpensive(productList);
            Console.Write("6.a Brangiausias produktas yra ");
            PrintProductWithPrice(mostExpensiveProduct);
            //6.b
            double maxPrice = 0.5;
            var mostExpensiveProductMax = ProductHelper.MostExpensive(productList, maxPrice);
            Console.Write($"6.b Brangiausias produktas, kuris nekainuoja daugiau {maxPrice} yra, ");
            PrintProductWithPrice(mostExpensiveProductMax);

            //7.d
            TestApplyDiscount(productList);

            //8.c
            var productUnknown = Product.CreateDefault();
            Console.WriteLine("8.c");
            Console.WriteLine($"{productUnknown.Name}\t{productUnknown.Price}\t{productUnknown.Quantity}\t{productUnknown.TotalValue}");
            var productName = Product.CreateDefault("TestProductName");
            Console.WriteLine($"{productName.Name}\t{productName.Price}\t{productName.Quantity}\t{productName.TotalValue}");

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
        public static void PrintProductWithPrice(Product product)
        {
            Console.WriteLine($"{product.Name} (kaina {product.Price}).");
            Console.WriteLine();
        }
        public static void TestApplyDiscount(List<Product> productList)
        {
            var produktas = productList[0];
            Console.WriteLine("7.d");
            Console.Write($"Produktas be nuolaidos ");
            PrintProductWithPrice(produktas);

            double nuolaida = 50.0;
            produktas.ApplyDiscount(nuolaida);
            Console.Write($"{nuolaida}% nuolaida ");
            PrintProductWithPrice(produktas);

            double minQty = 20;
            produktas = productList[1];
            Console.Write($"Produktas be nuolaidos ");
            PrintProductWithPrice(produktas);

            produktas.ApplyDiscount(nuolaida, minQty);
            Console.Write($"{nuolaida}% nuolaida ir {minQty} min. kiekiu ");
            PrintProductWithPrice(produktas);

            double maxPrice = 0.5;
            produktas = productList[3];
            Console.Write($"Produktas be nuolaidos ");
            PrintProductWithPrice(produktas);

            produktas.ApplyDiscount(nuolaida, minQty, maxPrice);
            Console.Write($"{nuolaida}% nuolaida, {minQty} min. kiekiu ir {maxPrice} maks. kaina.");
            PrintProductWithPrice(produktas);
        }
    }
}


