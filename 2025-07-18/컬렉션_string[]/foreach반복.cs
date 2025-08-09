using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class foreach반복
{
    public static void Main()
    {
        float[] arr = { 10.5f, 20.1f, 30.2f };
        float sum = 0.0f;

        foreach (float f in arr)
        {
            sum = sum + f;
        }
        Console.WriteLine((float)sum);
        Console.WriteLine(sum);
    }
}