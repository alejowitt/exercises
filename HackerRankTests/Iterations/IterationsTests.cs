using System;
using HackerRank.Iterations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Iterations
{
    [TestClass]
    public class IterationsTests
    {
        public IterationsTests()
        {
        }

        [TestMethod]
        public void BinaryGap()
        {
            var test = new BinaryGap();
            test.Run();
        }

        [TestMethod]
        public void CyclicRotation()
        {
            var test = new CycliccRotation();
            test.Run();
        }
    }
}
