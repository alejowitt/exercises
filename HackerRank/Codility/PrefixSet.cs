using System;
using System.Collections.Generic;

namespace HackerRank.Codility
{
    public class PrefixSet : IExcercise
    {
        public PrefixSet()
        {
        }

        public void Run()
        {
            solution(new[] { 2, 2, 1, 0, 1 });
            solution(new[] { 0 });
            solution(new[] { 1,1,1,1,1 });
            solution(new[] { 1, 2,3,4 });
            solution(new[] { 4,3,2,1 });
        }

        public int solution(int[] A)
        {
            var possibleSmallest = A.Length-1;
            var existingValues = new HashSet<int>();
            for(int i = 0; i< A.Length; i++)
            {
                if (!existingValues.Contains(A[i]))
                {
                    existingValues.Add(A[i]);
                    if (A[i] == A[possibleSmallest])
                        possibleSmallest = Math.Min(i, possibleSmallest);
                    else
                        possibleSmallest = i;

                }
            }
            return possibleSmallest;
        }
    }
}
