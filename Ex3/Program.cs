﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "file.txt";
            string[] fileContents = File.ReadAllLines(filePath);

            ExtractBankDetails(fileContents);

        }
        private static string ExtractBankDetails(string[] ibans)
        {

        }
    }
}
