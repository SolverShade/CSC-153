using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class PracticalMath
    {
        const decimal GRAVITY = 9.80m; 

        public static decimal FallingDistance(decimal seconds)
        {
            decimal distanceInMeters = (0.5m * GRAVITY * seconds) * (0.5m * GRAVITY * seconds);

            return Math.Round(distanceInMeters, 2); ;
        }
    }
}
