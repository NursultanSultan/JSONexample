using System;
using System.Collections.Generic;
using System.Text;

namespace forPractie29.Models
{
    class OrderItem
    {
        public int ID { get; set; }

        public Product product { get; set; }

        public double totalPrice { get; set; }

        public int Count { get; set; }

        
    }
}
