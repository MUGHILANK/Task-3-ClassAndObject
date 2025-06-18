using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Factorial
    {
        public void factorialNumber()
        {
            Console.WriteLine("Enter factorial number: ");
            int factData =Convert.ToInt32(Console.ReadLine());

            long a = 1;

            for (int i = 1; i <= factData; i++)
            {
                a *= i;
            }

            Console.WriteLine($"Factorial: {a}");

        }
    }
}
