using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author Name     Dong Hee Han
// Creation Date   25-09-2018
// Version Control 1.0
namespace Trigonometric
{
    //This is a library for calculating a Sine, cosine and tangent using a math library
    public class Trigonometric
    {
        public static double Sine(double x)
        {
            x = Math.PI* x / 180.0;
            return Math.Sin(x);
        }
        public static double Cosine(double x)
        {
            x = Math.PI * x / 180.0;
            return Math.Cos(x);
        }
        public static double Tangent(double x)
        {
            x = x * (Math.PI / 180);
            return Math.Tan(x);
        }
    }
}
