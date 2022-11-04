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
        begining:
            if (x > 0)
            {
                if (y > 0)
                {
                    x = x - 1;
                    y = y - 1;
                    Console.Write("C");
                    goto begining;
                }
                else
                {
                    Console.Write("D");

                }

            }
            else
            {
                Console.Write("E");
                goto g;
            }
            if (z > 0)
            {
                goto end;
            }

        g:
            Console.Write("G");


        end:
            Console.WriteLine();

        }
    }
}
