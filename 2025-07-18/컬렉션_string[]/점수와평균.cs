using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 점수와평균
{
    public static void Main()
    {
        int sum = 0;
        double avg = 0.0;
        int[] kor = new int[] { 100, 90, 80 };

        sum = kor[0] + kor[1] + kor[2];
        avg = (double)sum / (double)3.0;
        Console.WriteLine($"총점:{sum}그리고 평균:{avg:0.00}");

    }
}