using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price: {price}");
        }
    }
    internal class RefReturn
    {
        static void MainRefReturn()
        {
            Product product = new Product();
            ref int refLocalPrice = ref product.GetPrice();
            int normalLocalPrice = product.GetPrice();

            product.PrintPrice();
            Console.WriteLine($"Ref Local Price: {refLocalPrice}");
            Console.WriteLine($"Normal Local Price: {normalLocalPrice}");

            refLocalPrice = 200;
            product.PrintPrice();
            Console.WriteLine($"Ref Local Price: {refLocalPrice}");
            Console.WriteLine($"Normal Local Price: {normalLocalPrice}");

        }
    }
}
