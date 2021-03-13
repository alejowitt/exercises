using System;
namespace HackerRank.Mathematics
{
    public class PointReflection : IExcercise
    {
        public PointReflection()
        {

        }

        public void Run()
        {

            var result = findPoint(0, 0, 1, 1);
        }

        int[] findPoint(int px, int py, int qx, int qy)
        {
            var rx = 2*qx - px;
            var ry = 2 * qy - py;
            return new int[] { rx, ry };
        }
    }
}
