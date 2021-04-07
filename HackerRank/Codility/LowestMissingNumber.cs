using System;
using System.Collections.Generic;

namespace HackerRank.Codility
{


    /// <summary>
    /// 
    /// </summary>

    /*This is a demo task.

    Write a function:

    class Solution { public int solution(int[] A); }

        that, given an array A of N integers, returns the smallest positive integer(greater than 0) that does not occur in A.

       For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

    Given A = [1, 2, 3], the function should return 4.

    Given A = [−1, −3], the function should return 1.

    Write an efficient algorithm for the following assumptions:

    N is an integer within the range[1..100, 000];
    each element of array A is an integer within the range[−1, 000, 000..1, 000, 000].
    Copyright 2009–2021 by Codility Limited.All Rights Reserved.Unauthorized copying, publication or disclosure prohibited.*/
    public class LowestMissingNumber
    {
        public LowestMissingNumber()
        {
        }


        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            var hash = new HashSet<int>();
            int greatestNumberInArray = 0;
            foreach (int i in A)
            {
                if (i > greatestNumberInArray)
                    greatestNumberInArray = i;
                if (hash.Contains(i))
                    continue;
                hash.Add(i);
            }

            for (int x = 1; x <= greatestNumberInArray + 1; x++)
                if (!hash.Contains(x))
                    return x;
            return 0;
        }
    }
}
