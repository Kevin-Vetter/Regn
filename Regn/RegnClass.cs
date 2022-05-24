using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regn
{
    public class RegnClass
    {
        static public double TryParse()
        {
            double _value;
            while (!double.TryParse(Console.ReadLine(), out _value))
            {
                Console.Clear();
                Console.WriteLine("Ugyldig værdi!");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Indtast et tal: ");
            }
            return _value;
        }

        public static double Avg(double[] input)
        { 
            return Math.Round(input.Average(),3);
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
