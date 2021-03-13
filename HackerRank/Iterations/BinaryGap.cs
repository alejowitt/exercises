using System;
namespace HackerRank.Iterations
{
    public class BinaryGap : IExcercise
    {
        public BinaryGap()
        {
        }

        public void Run()
        {
            solution(32);
        }

        public int solution(int N)
        {
            int count = -1;
            int maxCount = 0;
            var s = Convert.ToString(N, 2);
            foreach(char c in s)
            {
                if (c == '1')
                    if (count == -1)
                        count = 0;
                    else
                    {
                        if (count > maxCount)
                            maxCount = count;
                        count = 0;
                    }
                else
                    count++;
            }
            return maxCount;
        }
    }
}
