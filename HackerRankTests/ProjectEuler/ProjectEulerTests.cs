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

    }
}
