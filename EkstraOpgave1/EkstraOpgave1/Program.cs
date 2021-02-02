using System;

namespace EkstraOpgave1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int retirementYear;
            int Years;
            int Retirement;
            Console.WriteLine("What is your current age?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("At what age do you wish to retire?");
            retirementYear = Convert.ToInt32(Console.ReadLine());
            Years = retirementYear - age;
            string år = "2021";
            DateTime dt = new DateTime(int.Parse(år), 1, 1);
            Retirement = dt.Year + Years;
            if (dt.Year > Retirement)
            {
                Console.WriteLine("Congratulations, you can already retire");
            }
            else
            {
                Console.WriteLine("It's " + dt.ToString("yyyy") + ", so you can retire in {0}", Retirement);
            }
        }
    }
}
