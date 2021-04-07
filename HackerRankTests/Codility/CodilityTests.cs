using System;
using HackerRank.Codility;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Codility
{
    [TestClass]
    public class CodilityTests
    {
        public CodilityTests()
        {
        }
        [TestMethod]
        public void FrogRiverOne()
        {
            var test = new FrogRiverOne();
            test.Run();
        }

        [TestMethod]
        public void MaxCounters()
        {
            var test = new MaxCounters();
            test.Run();
        }

        [TestMethod]
        public void Distinct()
        {
            var test = new Distinct();
            test.Run();
        }

        [TestMethod]
        public void NumberOfDiscIntersections()
        {
            var test = new NumberOfDiscIntersections();
            test.Run();
        }

        [TestMethod]
        public void CakeFactoryChallenge()
        {
            var test = new CakeFactoryChallenge();
            test.Run();
        }
    }
}
