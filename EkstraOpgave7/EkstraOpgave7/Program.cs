using System;

namespace EkstraOpgave7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.WriteLine("Enter a list of numbers, separated by spaces:");
            input = Console.ReadLine();
            var tal = input.Split(' ');
            Console.WriteLine("The even numbers are:");

            for (int i = 0; i < tal.Length; i++)
            {
                int numbers = Convert.ToInt32(tal[i]);
                if (numbers % 2 == 0)
                {
                    Console.Write(numbers + " ");
                }
            }
        }
    }
}
