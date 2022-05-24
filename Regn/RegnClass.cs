using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regn
{
    public class RegnClass
    {
        public static double Avg(double[] input)
        { 
            return input.Average();
        }

        public static double Max(double[] input)
        {
            return input.Max();
        }

        public static double Min(double[] input)
        {
            return input.Min();
        }
    }
}
