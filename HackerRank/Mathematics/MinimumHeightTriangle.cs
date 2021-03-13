using System;
namespace HackerRank.Mathematics
{
    public class MinimumHeightTriangle : BaseExcercise, IExcercise
    {
        public MinimumHeightTriangle()
        {

        }

        /// <summary>
        /// 𝐴=1/2 ⋅ base ⋅ height
        /// A/(1/2 ⋅ base) = h
        /// </summary>
        public void Run()
        {
            var tbase = RandomInt(1, Convert.ToInt32(Math.Pow(10, 6)));
            var area = RandomInt(1, Convert.ToInt32(Math.Pow(10, 6)));
            var result = lowestTriangle(17, 100);
        }

        int lowestTriangle(int tbase, int area)
        {
            int height = 1;
            while((tbase * height) / 2 < area)
            {
                height++;
            }
            return height;
        }
    }
}
