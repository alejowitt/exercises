using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.Arrays
{
    public class OddOccurence : BaseExcercise, IExcercise
    {
        public OddOccurence()
        {
        }

        public void Run()
        {
            var r = solution(new int[] { 9,3,9,3,9,7,9 });
        }

        public int solution(int[] A)
        {
            var values = new HashSet<int>();
            for (int i = 0; i < A.Length; i++)
            {
                if (values.Contains(A[i]))
                    values.Remove(A[i]);
                else
                    values.Add(A[i]);
            }

            return values.First();
        }
    }
}
