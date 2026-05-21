using System;
using System.Collections.Generic; 

namespace project01
{
    public class Customer
    {
        
        public string Id { get; set; } = "CUS-" + Guid.NewGuid().ToString().Substring(0, 5).ToUpper();

        private string name;
        private string email;

    
        public List<Order> Orders { get; set; } = new List<Order>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}