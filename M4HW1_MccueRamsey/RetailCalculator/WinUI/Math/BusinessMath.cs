using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI.Math
{
    public static class BusinessMath
    {
        public static decimal CalculateMarkUp(decimal wholeSalePrice, decimal markUpPercentage)
        {
            return decimal.Round(wholeSalePrice + (wholeSalePrice * markUpPercentage), 2);
        }

        public static decimal ConvertWholeNumberToPercent(decimal unConvertedNumber)
        {
            return unConvertedNumber / 100;
        }
    }
}
