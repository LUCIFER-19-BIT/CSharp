C# program to print the following pattern:
// 1
// 23
// 456
// 78910

using System;

class Program
{
    static void Main()
    {
        int num = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(num);
                num++;
            }
            Console.WriteLine();
        }
    }
}