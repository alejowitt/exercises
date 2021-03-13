using System;
namespace HackerRank.Iterations
{
    public class CycliccRotation : IExcercise
    {
        public CycliccRotation()
        {
        }

        public void Run()
        {
            var r = solution(new int[] { 3, 8, 9, 7, 6 }, 3);
        }

        public int[] solution(int[] A, int K)
        {
            if (A.Length == 0)
                return A;

            if (K == 0)
                return A;
            var res = new int[A.Length];
            res[0] = A[A.Length - 1];
            for (int i = 0; i < A.Length - 1; i++)
                res[i + 1] = A[i];
            return solution(res, K-=1);
        }
    }
}
