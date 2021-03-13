using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.TimeComplexity
{
    public class PermMissingElem : BaseExcercise, IExcercise
    {
        public PermMissingElem()
        {
        }

        public void Run()
        {
            var r = solution(SequencedIntArray(100000));
        }

        public int solution(int[] A)
        {
            long n = A.Length + 1;
            long expectedSum = n * (n+1)/2;
            long sum = 0;
            for (int i = 0; i < A.Length; i++)
                sum += A[i];
            return (int)(expectedSum - sum);
        }
    }
}
