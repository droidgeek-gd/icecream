using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<int> arr = new List<int> { 1, 3, 4, 5, 6 };
            int m = 6;
            new Solution().icecreamParlor(m, arr);
        }

        

    }
}
