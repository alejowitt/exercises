using System;
namespace HackerRank.Codility
{
    public class NumberOfDiscIntersections : IExcercise
    {
        public NumberOfDiscIntersections()
        {
        }

        public void Run()
        {
            solution(new[] { 1, 5, 2, 1, 4, 0 });
        }

        public int solution(int[] A)
        {
            var res = 0;
            const float tiny = 0.0001f;
            for (int i = 0; i< A.Length; i++)
            {
                for(int j = i+1; j < A.Length; j++)
                {
                    var currentRadius = A[j];
                    var prevRadius = A[i];
                    var diameterCurrent = 2 * currentRadius;
                    var diameterPrevious = 2 * prevRadius;
                    var centerDistance = diameterCurrent - diameterPrevious;
                    if (centerDistance > currentRadius + prevRadius) //far appart
                        continue;
                    if ((Math.Abs(centerDistance) < tiny) && (Math.Abs(currentRadius - prevRadius) < tiny))//the same
                        continue;
                    else
                        res++;
                }
            }
            return res;
        }
    }
}
