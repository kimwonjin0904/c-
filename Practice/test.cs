using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using static System.Console;

public class 키워드로가변길이매개변수처리
{
   public static int Sum(params int[] numbers)
    {
        int total = 0;

        foreach (int number in numbers)
        {
            total = total + number;      
        }
        return total;
    }
  static void Main()
    {
        int total = Sum(1, 2);
        Console.WriteLine(total);
    }
    //출력값:3
}


