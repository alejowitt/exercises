using System;
using HackerRank.PorjectEuler;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.ProjectEuler
{
    [TestClass]
    public class ProjectEulerTests
    {
        public ProjectEulerTests()
        {
        }

        [TestMethod]
        public void PointReflection()
        {
            var test = new Problem1();
            test.Run();
        }

        [TestMethod]
        public void Problem3_Factors()
        {
            var test = new Problem3();
            test.Run();
        }
    }
}
