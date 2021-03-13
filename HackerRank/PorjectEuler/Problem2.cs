﻿using System;
namespace HackerRank.PorjectEuler
{
    public class Problem2 : IExcercise
    {
        /// <summary>
        /// https://www.mathblog.dk/project-euler-problem-2/
        /// Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with 1 and 2, the first 10 terms will be:
        ///1, 2, 3, 5, 8, 13, 21, 34, 55, 89, …
        ///Find the sum of all the even-valued terms in the sequence which do not exceed four million.
        /// </summary>
        public Problem2()
        {
        }

        /// <summary>
        /// If we look at the Fibonacci sequence: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89 -> every 3rd number is even after f3(2)
        /// 4(Fn-3) + Fn-6 = Fn -> to calculate only even numbers
        /// </summary>
        public void Run()
        {
            long fib3 = 2;
            long fib6 = 0;
            long result = 2;
            long summed = 0;

            while (result < 4000000)
            {
                summed += result;

                result = 4 * fib3 + fib6;
                fib6 = fib3;
                fib3 = result;
            }
        }
    }
}