using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank.TimeComplexity
{
    public class FrogJmp : BaseExcercise, IExcercise
    {
        public FrogJmp()
        {
        }

        public void Run()
        {
            var r = solution(1, 5, 2);
        }

        public int solution(int X, int Y, int D)
        {

            int jumps = (int)Math.Round((decimal)((Y-X)/D));
            int currentDistance = (jumps * D)+X;
            if (currentDistance < Y)
            {
                jumps++;
            }
            return jumps;
        }
    }
}
