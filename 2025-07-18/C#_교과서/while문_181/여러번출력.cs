using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class while문_여러번출력
{
    public static void Main()
    {
        int i = 1;
        while (i <= 3)
        {
            Console.WriteLine($"증가:{i}");
            i++;
        }

    }
}