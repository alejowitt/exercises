using System;
using HackerRank.PorjectEuler;
using HackerRank.TimeComplexity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.ProjectEuler
{
    [TestClass]
    public class TimeComplexityTests
    {
        public TimeComplexityTests()
        {
        }

        [TestMethod]
        public void FrogJmp()
        {
            var test = new FrogJmp();
            test.Run();
        }

        [TestMethod]
        public void PermMissingElem()
        {
            var test = new PermMissingElem();
            test.Run();
        }
    }
}
