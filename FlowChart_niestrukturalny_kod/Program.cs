using System.Data.Common;
using System.Diagnostics.CodeAnalysis;
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
if(z > 0)
{
    Console.WriteLine();
    goto end;
}

g:
Console.Write("G");
Console.WriteLine();

end:
















































/*int x = data[0];
int y = data[1];
int z = data[2];
found:

if (x > 0)
{
    if (y > 0)
    {
        x = x - 1;
        y = y - 1;
        Console.Write("C");
        goto found;
    }
    else
    {
        Console.Write("D");
        if (z > 0)
        {
        punkttest:
            Console.WriteLine("");
            goto exit;
        }
        else
        {

            goto IfNo;
        }
    }
}
else
{
    goto punkttest;
    Console.Write("E");
    IfNo:
    Console.Write("G");
    

}
exit:*/
#if DEBUG
    Console.WriteLine("Press enter to close...");
    Console.ReadLine();
#endif
 
