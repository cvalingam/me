using System;

namespace DCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem_192 p192 = new Problem_192();
            int[] input = new int[] { 1, 5, 2, 1, 0, 2, 0 };
            Console.WriteLine(p192.BacktrackingSolution(input));
            // int[] input1 = new int[] { 1, 2, 1, 0, 0 };
            // Console.WriteLine(p192.Solution(input1));
            Console.ReadLine();
        }
    }
}
