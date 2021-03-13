using HackerRank.Mathematics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests
{
    [TestClass]
    public class MathTests
    {
        [TestMethod]
        public void PointReflection()
        {
            var test = new PointReflection();
            test.Run();
        }

        [TestMethod]
        public void MaxDraws()
        {
            var test = new MaximumDraws();
            test.Run();
        }

        [TestMethod]
        public void MinimumHeightTriangle()
        {
            var test = new MinimumHeightTriangle();
            test.Run();
        }

        [TestMethod]
        public void LeonardoAndPrime()
        {
            var n = 10000000000;
            var n2 = 99999999999;
            
            var test = new LeonardoAndPrime();
            test.Run();
        }
    }
}
