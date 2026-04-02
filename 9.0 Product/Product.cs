namespace Products
{
    public class Product
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "" || value == null)
                {
                    throw new EmptyStringException("Parameter Name cannot be null or empty");
                }
                else
                { _name = value; }
            }
        }
        private double _price;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new NonPositiveValueException("Parameter Price can have positive value only");
                }
                else
                { _price = value; }
            }
        }
        private double _quantity;
        public double Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                if (value < 0)
                {
                    throw new NegativeValueException("Parameter Quantity can only be 0 or greater");
                }
                else
                { _quantity = value; }
            }
        }
        public double TotalValue
        {
            get
            {
                return _price * _quantity;
            }
        }
        private static double _productCount;
        public static double ProductCount
        {
            get
            {
                return _productCount;
            }
        }

        public Product(string name, double quantity, double price)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            _productCount++;
        }
        public void ApplyDiscount(double percent)
        {
            Price *= (1 - percent / 100);
        }
        public void ApplyDiscount(double percent, double minQuantity)
        {
            if (_quantity >= minQuantity) ApplyDiscount(percent);
        }
        public void ApplyDiscount(double percent, double minQuantity, double maxPrice)
        {
            if (_price <= maxPrice) ApplyDiscount(percent, minQuantity);
        }

        public static Product CreateDefault()
        {
            return new Product("Unknown", 0, 0.01);
        }
        public static Product CreateDefault(string name)
        {
            return new Product(name, 0, 0.01);
        }
    }
}