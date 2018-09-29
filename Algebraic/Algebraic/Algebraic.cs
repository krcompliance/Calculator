using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author Name     Dong Hee Han
// Creation Date   25-09-2018
// Version Control 1.0
namespace Algebraic
{
    // This is a library for calculating a squareroot, cuberoot and Inverse using Math library
    public class Algebraic
    {
        public static double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
        public static double CubeRT(double x)
        {
            return Math.Pow(x, (double)1 / 3);
        }
        public static double Inverse(String original, double x)
        {
            double returnDouble = 0;
            if(original.Equals("Sin"))
            {
                returnDouble = Math.Asin(x);
                returnDouble = 180 * returnDouble / Math.PI;
            }
            if (original.Equals("Cos"))
            {
                returnDouble = Math.Acos(x);
                returnDouble = 180 * returnDouble / Math.PI;
            }
            if (original.Equals("Tan"))
            {
                returnDouble = Math.Atan(x);
                returnDouble = returnDouble * (180 / Math.PI);
            }
            if (original.Equals("Sqrt"))
            {
                returnDouble = (x * x);
            }
            if (original.Equals("CubeR"))
            {
                returnDouble = (x * x * x);
            }
            return returnDouble;
        }
    }
}
