using System;
using System.Collections.Generic;

namespace HackerRank.Mathematics
{
    public class LeonardoAndPrime : BaseExcercise, IExcercise
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/leonardo-and-prime/problem?h_r=next-challenge&h_v=zen
        /// </summary>
        /// 

        public void Run()

        {
            var n = new List<long>()
            {
                1,2,3,500,5000, 10000000000
            };
            foreach(long i in n)
                Console.WriteLine(primeCount(i));
        }

        public int primeCount(long n)
        {
            long i = 2;
            var count = 0;
            while(i < n)
            {
                var rcount = primeCount2(i);
                if (rcount > count)
                    count = rcount;
                i++;
            }
            return count;
        }

        public int primeCount2(long n)
        {
            if (n == 1)
                return 0;
            long current = n;
            long i = 2;
            HashSet<long> hash = new HashSet<long>();
            while ((decimal)(current / i) > 1)
            {
                if (current % i == 0)
                {
                    hash.Add(i);
                    current /= i;
                }
                i++;
            }
            return hash.Count + 1;
        }
    }
}
