using System;
using HackerRank.Practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankTests.Practice
{
    [TestClass]
    public class PracticeTests
    {
        public PracticeTests()
        {
        }

        [TestMethod]
        public void Frequencies()
        {
            var test = new FrequencyQueries();
            test.Run();
        }

        [TestMethod]
        public void BalancedBrackets()
        {
            var test = new BalancedBrackets();
            test.Run();
        }
    }
}
