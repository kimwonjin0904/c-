using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 더하기_2
{
    static int Plus(int x, int y)
    {
        return x + y; // 간단하게 x와 y를 더한 값을 반환

        

    }
    static void Main()
    {
        int a = 3;
        int b = 5;
        int sum = Plus(3, 5); // Plus 함수 호출
        Console.WriteLine($"a+b={sum}");
    }



}


