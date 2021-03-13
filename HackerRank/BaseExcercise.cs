using System;
using Randomizer;

namespace HackerRank
{
    public class BaseExcercise
    {
        public BaseExcercise()
        {
        }

        public double RandomDouble(double min, double max)
        {
            return new RandomDoubleGenerator().GenerateValue(min, max);
        }

        public int RandomInt(int min, int max)
        {
            return new RandomIntegerGenerator().GenerateValue(min, max);
        }

        public int[] RandomIntArray(long length, int min, int max)
        {
            var arr = new int[length];
            for (var i = 0; i < arr.Length; i++)
                arr[i] = new RandomIntegerGenerator().GenerateValue(min, max);
            return arr;
        }

        public int[] SequencedIntArray(long length)
        {
            var arr = new int[length];
            for (var i = 0; i < arr.Length; i++)
                arr[i] += i == 0 ? 1 : arr[i-1]+1;
            return arr;
        }
    }
}
