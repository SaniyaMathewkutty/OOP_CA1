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

            string[,] ibans = new string[,]
            {
                {""}
            };

            for (int i = 0; i < fileContents.Length; i++)
            {
                for (int j = 0; j < fileContents[i].Length; j++)
                {
                    ibans[i, j] = File.ReadAllText(fileContents[i]);
                    Console.Write("bank code = {0}", ExtractBankCode(fileContents));
                    Console.Write("Sort code = {0}", ExtractSortCode(fileContents));
                    Console.Write("Account number = {0}", ExtractAcNo(fileContents));
                }
            }

            Console.ReadLine();

        }
        private static string ExtractBankCode(string[] ibans)
        {
            // Variable to return with bank code
            string bankCode = ""; 

            // Arrays to store the bank details 
            string[] bankCodes = new string[ibans.Length];

            for (int i = 0; i < 8; i++)
            {
                bankCode += bankCodes[i];
            }
            return bankCode;

          
        }
        private static string ExtractSortCode(string[] ibans)
        {
            string sortCode = "";
            string[] sortCodes = new string[ibans.Length];

            for (int i = 8; i < 14; i++)
            {
                sortCode += sortCodes[i];
            }

            return sortCode;
        }

        private static string ExtractAcNo(string[] ibans)
        {
            string acNo = "";
            string[] acNos = new string[ibans.Length];

            for (int i = 14; i < 22; i++)
            {
                acNo += acNos[i];
            }

            return acNo;
        }
    }
}
