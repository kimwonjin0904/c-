using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 가로구구단
{
    public static void Main()
    {
        const int N = 100;
              int i = 1;
              int sum = 0;
        while (i <= N)
        {
            sum = sum + i; // i를 sum에 더함 (1+0=1)..
           // Console.WriteLine($"1~100까지합: {sum}");
            i++;
        }
        Console.WriteLine($"1~100까지합: {sum}");
    }
}

