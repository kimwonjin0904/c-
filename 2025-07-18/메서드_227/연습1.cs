using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 연습1
{

    static void Main()
    {
        Console.WriteLine("입력하세요_");
        int x = Convert.ToInt32((Console.ReadLine()));
        double a = (int)x;

        Console.WriteLine("입력22");
        double y = Convert.ToDouble(Console.ReadLine());

        double sum = 0;
        sum = a + y;
        Console.WriteLine($"{sum}");

    }


}


