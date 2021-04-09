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
            //solution(6, 2, new int[] { 2 }, new int[] { 4 }, new int[] { 1 });
            solution(6, 1, new int[] { 2 }, new int[] { 4 }, new int[] { 1 });
            //solution(3, 2, new int[] { 1, 3, 3, 1, 1 }, new int[] { 2, 3, 3, 1, 2 }, new int[] { 1, 2, 1, 2, 2 });
            //solution(5, 3, new int[] { 1, 1, 4, 1, 4 }, new int[] { 5, 2, 5, 5, 4 }, new int[] { 1, 2, 2, 3, 3 });
            //solution(5, 2, new int[] { 1, 1, 2 }, new int[] { 5, 5, 3 }, new int[] { 1, 2, 1 });
        }


        public int solution(int N, int K, int[] A, int[] B, int[] C)
        {
            //K = Layers
            //N = #cakes
            var cakes = new Dictionary<int, List<int>>();
            var damagedCakes = new HashSet<int>();
            for (int i = 0; i<C.Length; i++)
            {
                var to = A[i] - 1;
                var from = B[i]; 
                for(int x = to; x < from; x++)
                {
                    if (!cakes.ContainsKey(x))
                        cakes.Add(x, new List<int>());

                    var prev = cakes[x].Count == 0 ? 0 : cakes[x][cakes[x].Count - 1];
                    if (C[i] != prev+1 && !damagedCakes.Contains(x))
                    {
                        damagedCakes.Add(x);
                        continue;
                    }
                    cakes[x].Add(C[i]);
                }
            }
            foreach (var cake in cakes)
                if (cake.Value.Count != K)
                    damagedCakes.Add(cake.Key);
            return cakes.Count - damagedCakes.Count;
        }
    }
}

