using System;
using System.Collections.Generic;

namespace HackerRank.Codility
{
    public class CakeFactoryChallenge : IExcercise
    {
        public CakeFactoryChallenge()
        {
        }

        public void Run()
        {
            solution(5, 2, new int[] { 1, 1, 2 }, new int[] { 5,5,3 }, new int[] { 1, 2, 1 });
        }

        public int solution(int N, int K, int[] A, int[] B, int[] C)
        {
            //K = Layers
            //N = #cakes
            var cakes = new Dictionary<int, List<int>>();
            for(int i = 0; i<C.Length; i++)
            {
                var to = A[i] - 1;
                var from = B[i]; 
                for(int x = to; x < from; x++)
                {
                    if (!cakes.ContainsKey(x))
                        cakes.Add(x, new List<int>());
                    cakes[x].Add(C[i]);
                }
            }
            var missingCount = 0;
            foreach(var cake in cakes)
            {
                if (cake.Value.Count != K)
                {

                    missingCount++;
                    continue;
                }
                for(int x = 0; x < cake.Value.Count; x++)
                {
                    var prev = x == 0 ? 0 : cake.Value[x - 1];
                    if (cake.Value[x] != prev + 1)
                    {

                        missingCount++;
                        break;
                    }
                }
            }
            return N - missingCount;
        }
    }
}
