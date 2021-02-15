using System;

namespace EkstraOpgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            double A = 0, r, t, n, P; 
            Console.WriteLine("What is the principal amount?");
            P = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the annual rate of interest?");
            r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the number of years the ammount is invested?");
            t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the number of times the interest is compounded per year?");
            n = Convert.ToDouble(Console.ReadLine());

            double krop = 1 + (r / 100 / n);
            double eksponent = n * t;
            A = P * Math.Pow(krop, eksponent);

            Console.WriteLine("${0} invested at {1}% for {2} years compunded {3} times per year is ${4}", P, r, t, n, A);
        }
    }
}
