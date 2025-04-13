using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp
{
    class OrderItem
    {
        public int Amount { get; set; }
        public int Price { get; set; }
    }
    internal class LogicalPattern
    {
        static double GetPrice(OrderItem orderItem) => orderItem switch
        {
            OrderItem { Amount: 0 } or OrderItem { Price: 0 }
                => 0.0,
            OrderItem { Amount: >= 100 } and OrderItem { Price: >= 10_000 }
                => orderItem.Amount * orderItem.Price * 0.8,
            not OrderItem { Amount: < 100 }
            => orderItem.Amount * orderItem.Price * 0.9,
            _ => orderItem.Amount * orderItem.Price

        };

        static void MainLogicalPattern()
        {
            Console.WriteLine(GetPrice(new OrderItem() { Amount = 0, Price = 10_000 }));
        }
    }
}
