using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get input from user
            Console.WriteLine("Enter temperature : ");
            int temperature = int.Parse(Console.ReadLine());

            // Validate number and display message
            if (temperature >= 18 && temperature <= 22)
                Console.WriteLine("Temperature is in the normal range.");
            else
                Console.WriteLine("The temperature is outside the normal range");

            Console.ReadLine();
        }
    }
}
