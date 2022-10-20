using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string memberType;
            double discount = 0, charge = 50, price = 0;

            // Get input from user and initialise variables
            Console.Write("Enter the type of member you are : ");
            memberType = Console.ReadLine().ToLower();

            // Switch statement to determine discount
            switch (memberType)
            {
                case "children":
                    discount = 0.5;
                    break;
                case "students":
                    discount = 0.2;
                    break;
                case "oap":
                    discount = 0.1;
                    break;
                default:
                    discount = 0;
                    break;
            }

            // Calculate price including discount (if any)
            price = charge - (charge * discount);

            // Display discounted price
            Console.Write($"Your price = EUR {price}");
            Console.ReadLine();

            Console.ReadLine();
        }
    }
}
