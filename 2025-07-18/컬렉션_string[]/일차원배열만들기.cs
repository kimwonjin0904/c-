using System;
using static System.Console;

public class 일차원배열만들기
{
    public static void Main()
    {


        ushort[] numbers = new ushort[5];
        numbers[0] = 1;
        numbers[1] = 2;

        Console.WriteLine($"{numbers[0]},{numbers[1]}");

    }
}