using System;
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
            // Variables to store details for each line
            string bankCode = "", sortCode = "", acNo = "", iban = "";

            // Arrays to store the bank details 
            string[] bankCodes = new string[ibans.Length];
            string[] sortCodes = new string[ibans.Length];
            string[] acNos = new string[ibans.Length];

            for (int i = 0; i < ibans.Length; i++)
            {
                iban = ibans[i];

                for (int j = 0; j < 8; j++)
                {
                    bankCode += bankCodes[j];
                }

                for (int k = 8; k < 14; k++)
                {
                    sortCode += sortCodes[i];
                }

                for (int l = 14; l < 22; l++)
                {
                    acNo += acNos[i];
                }
            }

          
        }
    }
}
