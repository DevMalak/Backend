using System;
using System.Collections.Generic;

namespace project01
{
    public class Order
    {
       
        public string OrderId { get; set; } = "ORD-" + DateTime.Now.Ticks.ToString().Substring(10);

        
        public Customer Customer { get; set; }

        public List<Product> Products = new List<Product>();

        public string Status { get; set; }

        public double GetTotal()
        {
            double total = 0;

            foreach (var p in Products)
            {
                
                total += (p.Price - p.CalculateDiscount()) * p.Quantity;
            }

            return total;
        }
    }
}