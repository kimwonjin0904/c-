using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 큰값작은값구하기
{
    static int Max(int x, int y)
    {
        return x > y ? x : y;   // x가 y보다 크면 x를 반환, 아니면 y를 반환
    }
    static int Min(int x, int y)
    {
        if (x < y)
        {
            return x;  // x가 y보다 작으면 x를 반환
        }
        else
        {
            return y;  // 그렇지 않으면 y를 반환
        }
    }
    static void Main()
    {
        Console.WriteLine(Max(3, 5));
        Console.WriteLine(Min(-3, 5));
    }
}







