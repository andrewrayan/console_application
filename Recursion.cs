using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace consoleappliation
{
    class Recursion
    {
        public int Factorial(int number)
        {
            if (number == 1)
            {
                return number;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
