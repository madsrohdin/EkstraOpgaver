using System;
using System.Collections;

namespace EkstraOpgave6
{
    class Program
    {
        static void Main(string[] args)
        {
            string Terminate;
            ArrayList employees = new ArrayList();
            employees.Add("John Smith");
            employees.Add("Jackie Jackson");
            employees.Add("Chris Jones");
            employees.Add("Amanda Cullen");
            employees.Add("Jeremy Goodwin");

            Console.WriteLine("There are {0} employees:", employees.Count);
            foreach (var item in employees)
            {
                Console.WriteLine(item.ToString());
            }
            
            Console.WriteLine("\nEnter an employee to remove:");
            Terminate = Console.ReadLine();

            if (employees.Contains(Terminate))
            {
                employees.Remove(Terminate);
                Console.WriteLine("\nThere are {0} employees:", employees.Count);
                foreach (var item in employees)
                {
                    Console.WriteLine(item.ToString());
                }
            }
            else
            {
                Console.WriteLine("\nEmployee not found.");
            }
        }
    }
}
