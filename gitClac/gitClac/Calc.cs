using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitClac
{
    internal class Calc
    {
        public double plus(double a, double b)
        {
            return a + b;
        }   
        
        public double minus(double a, double b) 
        { 
            return a - b; 
        }

        public double multiply(double a, double b)
        {
            double result = a * b;
            return result;
        }

        public double div(double a, double b)
        {
            if (b == 0)
            {
                Console.Write("CANNOT DIVIDE BY ZERO");
                return 0;
            }
            else
            {
                return a / b;
            }
        }
    }   
}
