using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace WhatAPerfectPowerAnyway
{

    /*A perfect power is a classification of positive integers:

In mathematics, a perfect power is a positive integer that can be expressed as an integer power of another positive integer.More formally, n is a perfect power if there exist natural numbers m > 1, and k > 1 such that mk = n.

Your task is to check wheter a given integer is a perfect power.If it is a perfect power, return a pair m and k with mk = n as a proof.Otherwise return Nothing, Nil, null, NULL, None or your language's equivalent.


Note: For a perfect power, there might be several pairs.For example 81 = 3^4 = 9^2, so (3,4) and(9,2) are valid solutions.However, the tests take care of this, so if a number is a perfect power, return any pair that proves it.

Examples
IsPerfectPower(4) => (2,2)
IsPerfectPower(5) => null
IsPerfectPower(8) => (2,3)
IsPerfectPower(9) => (3,2)*/

    /*Совершенная степень — это классификация положительных целых чисел:

В математике совершенная степень — это положительное целое число, которое может быть выражено как целая степень другого положительного целого числа. Более формально, n является совершенной степенью, если существуют натуральные числа m > 1 и k > 1, такие что mk = n.

Ваша задача состоит в том, чтобы проверить, является ли данное целое число совершенной степенью. Если это совершенная степень, верните пару m и k с mk = n в качестве доказательства. В противном случае верните Nothing, Nil, null, NULL, None или эквивалент вашего языка .


Примечание. Для идеальной степени может быть несколько пар. Например, 81 = 3 ^ 4 = 9 ^ 2, поэтому (3,4) и (9,2) являются допустимыми решениями. Однако тесты позаботятся об этом, поэтому, если число является совершенной степенью, верните любую пару, которая это доказывает.

Примеры
IsPerfectPower(4) => (2,2)
IsPerfectPower(5) => ноль
IsPerfectPower(8) => (2,3)
IsPerfectPower(9) => (3,2)*/
    internal class Program
    {
        static void Main(string[] args)
        {
            IsPerfectPower(2);
            Console.WriteLine(IsPerfectPower(4));
            Console.ReadLine();
        }

  
        public static (int, int)? IsPerfectPower(int n)
        {
            int logOfN = (int)Math.Ceiling(Math.Log(n) / Math.Log(2));

            for (int m = 2; m <= n / m; m++)
            {
                for (int k = 2; k <= logOfN; k++)
                {
                    if (n % m == 0 && Math.Pow(m, k) == n)
                    {
                        return (m,k); 
                    }
                }
            }

            return null;
        }

        public static (int, int)? IsPerfectPower1(int n)
        {
            int border = (int)Math.Sqrt(n);
            for (int i = 2; i <= border; border--)
            {
                int deg = Convert.ToInt32(Math.Log(n, border));
                if (Math.Pow(border, deg) == n)
                {
                    return (border, deg);
                }
            }
            return null;
        }

        public static (int, int)? IsPerfectPower3(int n)
        {
            if (n < 2)
                return null;
            for (int i = 2; i < 1000; i++)
                for (int j = 2; j < 1000; j++)
                    if (Math.Pow(i, j) == n)
                        return (i, j);
            return null;
        }

        public static (int, int)? IsPerfectPower4(int n)
        {
            for (int i = 2; i <= Math.Round(Math.Sqrt(n), 0); i++)
            {
                for (int j = 2; n >= Math.Pow(i, j); j++)
                {
                    if (Math.Pow(i, j) == n)
                        return (i, j);
                }
            }
            return null;
        }
    }
}
