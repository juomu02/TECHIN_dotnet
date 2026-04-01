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
                { throw new EmptyStringException("Parameter Name cannot be null or empty"); }
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
                { throw new NonPositiveValueException("Parameter Price can have positive value only"); }
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
                { throw new NegativeValueException("Parameter Quantity can only be 0 or greater"); }
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

        public Product(string name, double price, double quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}