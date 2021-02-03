using System;

namespace EkstraOpgave2
{
    class Program
    {
        static void Main(string[] args)
        {
            double price1;
            double price2;
            double price3;
            int quantity1;
            int quantity2;
            int quantity3;
            double item1;
            double item2;
            double item3;
            double subtotal;
            double tax;
            double total;

            Console.WriteLine("Please enter the price of your first item:");
            price1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity of your first item:");
            quantity1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the price of your second item:");
            price2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity of your second item:");
            quantity2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the price of your third item:");
            price3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the quantity of your third item:");
            quantity3 = Convert.ToInt32(Console.ReadLine());

            item1 = price1 * quantity1;
            item2 = price2 * quantity2;
            item3 = price3 * quantity3;
            subtotal = item1 + item2 + item3;
            tax = subtotal / 100 * 5.5;
            total = subtotal + tax;

            Console.WriteLine("Subtotal: $" + subtotal);
            Console.WriteLine("Tax: $" + tax);
            Console.WriteLine("Total: $" + total);

        }
    }
}
