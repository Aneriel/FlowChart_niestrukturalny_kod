using System;
using System.Diagnostics.CodeAnalysis;

namespace FlowChart
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] data = Array.ConvertAll<string, int>(input.Split(" "), int.Parse);
            int x = data[0];
            int y = data[1];
            int z = data[2];
        
        }
    }
}
