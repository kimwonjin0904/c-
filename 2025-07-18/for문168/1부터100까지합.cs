using System;
using System.Security.Cryptography;
using System.Text;
using static System.Console;

public class for문
{
    public static void Main()
    {
        //1부터 100까지 정수의합
        int sum = 0;

        for (int i = 1; i <= 100; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine($"1부터 100까지 합은{sum}");
    }
}