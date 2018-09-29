using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Author Name     Dong Hee Han
// Creation Date   25-09-2018
// Version Control 1.0
namespace BasicMath
{
   // This is a library for add, subtract, divide and multiply
    public class Arithmetic
    {
        public static double Add(double a, double b)
        {
            return (a + b);
        }
        public static double Sub(double a, double b)
        {
            return (a - b);
        }
        public static double Div(double a, double b)
        {
            return (a / b);
        }
        public static double Mult(double a, double b)
        {
            return (a * b);
        }
    }
}
