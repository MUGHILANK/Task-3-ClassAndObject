using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Prime
    {
        public void primeNumber(int num)
        {
                bool isPrime = true;

                if (num <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"Prime number: {num}");
                }
                else
                {
                    Console.WriteLine($"Not Prime Number: {num} ");
                }
        }


        public void primeNumber(long factData)
        {
           

            long a = 1;

            for (int i = 1; i <= factData; i++)
            {
                a *= i;
            }

            Console.WriteLine($"Factorial: {a}");

        }


        public string primeNumber(string name)
        {

            char[] input = name.ToCharArray();
            Array.Reverse(input);

            string newValue = new string(input);

            return newValue;

        }


    }

}
