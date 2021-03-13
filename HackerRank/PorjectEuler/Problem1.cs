using System;
namespace HackerRank.PorjectEuler
{
    public class Problem1 : IExcercise
    {
        /// <summary>
        /// https://www.mathblog.dk/project-euler-problem-1/
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public Problem1()
        {
        }

        public void Run()
        {
            var result = SumDivisbleBy(3, 999) + SumDivisbleBy(5, 999) - SumDivisbleBy(15, 999);
        }

        /// <summary>
        /// Geometric progression/Arithmetic progression
        /// (n(n+1))/2 n is the largest int to add
        /// And the numbers divisible by p 5+10+15+20+…+995 = p*(1+2+3+4+…+199)
        /// so a progression for numbers divisible by p is
        /// p * ((n(n+1))/2)
        /// n/p is the amount of numbers between 1-n divisible by p
        /// so the formula for the progression is n * (p / n) * ((p / n) + 1) / 2;
        /// </summary>
        /// <param name="n"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        private int SumDivisbleBy(int n, int p)
        {
            return n * (p / n) * ((p / n) + 1) / 2;
        }
    }
}
