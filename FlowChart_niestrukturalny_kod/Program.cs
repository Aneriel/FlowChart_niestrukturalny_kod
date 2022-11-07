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
            
            while(y>0&&x>0)
            {
                x--;
                y--;
                Console.Write("C");
            }
            
            if (x > 0)
            {

            }
            else
            {
                y=1;
                Console.Write("E");
                Console.Write("G");
                Console.WriteLine();
            }
            if (y > 0)
            {

            }
            else
            {
                Console.Write("D");
                if (z > 0)
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("G");
                    Console.WriteLine();
                }
            }
            #if DEBUG
            Console.WriteLine("By zakończyć emulacje naciśnij enter");
            Console.ReadLine();
            #endif

        }
    }
}
