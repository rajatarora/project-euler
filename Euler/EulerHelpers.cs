﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class EulerHelpers
    {
        public static List<long> FibonacciSequence(long maxValue)
        {
            List<long> fibonacci = new List<long>() { 1, 1 };
            while (fibonacci[fibonacci.Count - 1] < maxValue)
            {
                fibonacci.Add(fibonacci[fibonacci.Count - 1] + fibonacci[fibonacci.Count - 2]);
            }
            fibonacci.Remove(fibonacci[fibonacci.Count - 1]);
            return fibonacci;
        }

        public static Boolean IsPrime(long number)
        {
            if (number == 2 || number == 3) return true;
            double sqrtNumber = Math.Sqrt(number);

            for (long i = 2; i <= sqrtNumber; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static Boolean IsPalindrome(string input)
        {
            char[] arrInput = input.ToCharArray();
            Array.Reverse(arrInput);
            return input.Equals(new string(arrInput));
        }

        public static Boolean IsPythagoreanTriplet(int a, int b, int c)
        {
            if (a < b && b < c)
            {
                return (Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2);
            }
            else
            {
                return false;
            }
        }
    }
}
