using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialise variables and arrays
            double total = 0;
            string[] stations = new string[] { "Sligo", "Dublin", "Cork" };
       
            double[,] rainfallFigures = new double[,]
            {
                {6.9, 7.1, 7.2},
                {6.1, 6.4, 6.3},
                {6.5, 6.7, 6.9}
            };

            double[] averages = new double[3];

            // Loop through eahc row in array
            for (int i = 0; i < rainfallFigures.GetLength(0); i++)
            {
                for ( int j = 0; j < rainfallFigures.GetLength(1); j++ )
                {
                    averages[i] = rainfallFigures[i, j];
                }
            }

            foreach (string station in stations)
            {
                for (int i = 0; i < averages.GetLength(0); i++ )
                    Console.WriteLine("average rainfall for {0} station = {1}", station, averages[i]);
            }
        }
    }
}
