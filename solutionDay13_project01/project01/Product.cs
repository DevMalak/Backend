using System;

namespace project01
{
    public class Product
    {
        
        public string Id { get; set; } = Guid.NewGuid().ToString().Substring(0, 5).ToUpper();

        private string name;
        private double price;
        private int quantity;

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
            }
        }

        public int Quantity
        {
            get { return quantity; }
            set
            {
                if (value >= 0)
                    quantity = value;
            }
        }
        public virtual double CalculateDiscount()
        {
            return 0; 
        }
    }


    public class ElectronicsProduct : Product
    {
        public override double CalculateDiscount()
        {
            // خصم 10% خاص بالإلكترونيات فقط
            return Price * 0.1;
        }
    }
}