using System;
namespace HackerRank.Mathematics
{
    public class HandshakeCombination : IExcercise
    {
        public HandshakeCombination()
        {

        }

        public void Run()
        {
            var result = combination(5277);
        }

        //combination formula 𝑛!/(𝑟!(𝑛−𝑟)!)  ==> n(n-1)/2!
        int combination(int n)
        {
            decimal res = (n * (n - 1)) / 2;
            return Convert.ToInt32(Math.Round(res));
        }
    }
}
