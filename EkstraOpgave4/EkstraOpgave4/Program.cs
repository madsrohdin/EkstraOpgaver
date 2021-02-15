using System;

namespace EkstraOpgave4
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight, height, bmi;
            Console.WriteLine("Please enter your weight in lbs:");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your height in inches:");
            height = Convert.ToDouble(Console.ReadLine());

            bmi = (weight / (height * height)) * 703;

            Console.WriteLine("Your BMI is: {0}", bmi);

            if (bmi <= 18.5)
            {
                Console.WriteLine("You are underwight. Please consult your doctor");
            }
            else if (bmi >= 25.0)
            {
                Console.WriteLine("You are overweight. Please consult your doctor");
            }
            else
            {
                Console.WriteLine("You are within the ideal weight range");
            }
            
        }
    }
}
