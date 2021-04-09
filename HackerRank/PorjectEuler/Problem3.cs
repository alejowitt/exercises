using System;
namespace HackerRank.PorjectEuler
{
    public class Problem3 : IExcercise
    {
        /// <summary>
        /// The prime factors of 13195 are 5, 7, 13 and 29
        ///What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public Problem3()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            const long numm = 600851475143;
            long newnumm = numm;
            long largestFact = 0;

            int counter = 2;
            while (counter * counter <= newnumm)
            {
                if (newnumm % counter == 0)
                {
                    newnumm = newnumm / counter;
                    largestFact = counter;
                }
                else
                {
                    counter++;
                }
            }
            if (newnumm > largestFact)
            { // the remainder is a prime number
                largestFact = newnumm;
            }
        }
    }
}
