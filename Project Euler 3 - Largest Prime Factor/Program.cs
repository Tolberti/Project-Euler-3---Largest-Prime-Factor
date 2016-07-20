using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// What is the largest prime factor of the number 600851475143 ?


namespace Project_Euler_3___Largest_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            long BaseNumber = 600851475143; // The number we want to find the largest prime factor of
            long TestNumber; //The number to check the primality of.
            bool PrimeFound = false; // Is the number we're checking a prime?
            int factor = 1; // The current factor to try dividing by.
            while (PrimeFound != true)
            {
                if (BaseNumber % factor == 0)
                {
                    TestNumber = (BaseNumber / factor);
                    Console.WriteLine("Testing {0}...", TestNumber);
                    PrimeFound = PrimeTest(TestNumber);
                    if (PrimeFound)
                    {
                        Console.WriteLine("highest common prime!");
                        Console.ReadKey();
                        return;
                    }
                    else Console.WriteLine("not prime.\n");
                }
                factor++;
            }
        }
        static bool PrimeTest(long TestNumber)
        {
            long i;
            for (i = 2; i < TestNumber; i++)
            {
                if ((TestNumber % i) == 0) return false;
            }
            return true;
        }
    }
}
