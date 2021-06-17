using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Solution
    {
        public void icecreamParlor(int m, List<int> arr)
        {
            var result = recursivePair(m, arr);
            Console.WriteLine($"They are at indices {result[0]} and {result[1]}");
            Console.ReadKey();
        }

        int currentIndex = 1;
        List<int> result = new List<int>();

        List<int> recursivePair(int m, List<int> arr)
        {
            for (int i = currentIndex; i < arr.Count; i++)
            {
                if (arr[currentIndex - 1] + arr[i] == m)
                    result = new List<int> { currentIndex, i + 1 };
            }
            if (result.Count > 0)
                return result;
            else
            {
                currentIndex++;
                return recursivePair(m, arr);
            }
        }
    }
}
