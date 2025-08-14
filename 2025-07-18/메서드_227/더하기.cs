using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 더하기
{
    static int Plus(int x, int y)
    {
        int sum = 0;
        sum = x + y;

        return sum;

    }
    static void Main()
    {
        int sum = Plus(5, 1);
        Console.WriteLine(sum);
    }



}


