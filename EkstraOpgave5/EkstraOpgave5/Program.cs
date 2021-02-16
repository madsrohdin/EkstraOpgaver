using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace EkstraOpgave5
{
    class Program
    {
        static void Main(string[] args)
        {
            string password;

            Console.WriteLine("Please enter a password:");
            password = Console.ReadLine();

            //Very weak
            if (password.All(char.IsDigit) && password.Length < 8)
            {
                Console.WriteLine("The password '{0}' is a very weak password.", password);
            }

            //Weak
            else if (password.All(char.IsLetter) && password.Length < 8)
            {
                Console.WriteLine("The password '{0}' is a weak password.", password);
            }

            //Very strong
            else if (password.Any(char.IsDigit) && password.Any(char.IsLetter) && password.Any(char.IsPunctuation) && password.Length >= 8)
            {
                Console.WriteLine("The password '{0}' is a very strong password", password);
            }

            //Strong
            else if (password.Any(char.IsLetter) && password.Any(char.IsDigit) && password.Length >= 8)
            {
                Console.WriteLine("The password '{0}' is a strong password.", password);
            }
        }
    }
}
