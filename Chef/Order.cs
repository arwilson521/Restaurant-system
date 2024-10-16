using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_System
{
    public class Order
    {
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public override string ToString()
        {
            return $"{Quantity} x {ItemName}";
        }
    }
}
