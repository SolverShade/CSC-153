using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SalesLibrary
{
    public static class Operations
    {       
        //parse the text file for decimals to be returned in an array 
        public static decimal[] FetchDecimals(string fileName)
        {
            List<decimal> retrivedDecimals = new List<decimal>();
            int decimalAmount = 0;

            foreach (string line in File.ReadLines("Text_Files/" + fileName))
            {
                if (Decimal.TryParse(line, out decimal result))
                {
                    retrivedDecimals.Add(result);
                    decimalAmount++;
                }
            }

            decimal[] fixedDecimals = new decimal[decimalAmount];

            for(int index = 0; index < decimalAmount; index++)
            {
                fixedDecimals[index] = retrivedDecimals[index];
            }

            return fixedDecimals;
        }

        //calculate the total of an array of decimals 
        public static decimal CalculateTotal(decimal[] numberSelection)
        {
            decimal total = 0;
            foreach(decimal number in numberSelection)
            {
                total += number;
            }

            return total;
        }

    }
}
