using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObject
{
    internal class Prime
    {
        public void primeNumber()
        {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

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



    }

}
