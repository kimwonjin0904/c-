using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 사용자입력
{
    public static void Main()
    {
        int[] students = new int[3];
        Console.WriteLine("입력하세요");
        students[0] = Convert.ToInt32(Console.ReadLine());
        students[1] = Convert.ToInt32(Console.ReadLine());
        students[2] = Convert.ToInt32(Console.ReadLine());

        int total = students[0] + students[1] + students[2];
        Console.WriteLine(total);
    }
}