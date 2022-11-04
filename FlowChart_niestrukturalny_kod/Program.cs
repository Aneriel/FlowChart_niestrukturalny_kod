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

            while (y <= 0) {
            while(x <= 0)
                {
                    Console.WriteLine("E");
                }
                x--;
                y--;
                Console.Write("C");
            }


}
