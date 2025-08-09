using System;
using static System.Console;

public class 문자열인덱서사용
{
    public static void Main()
    {
        string str = "ABC";
        Console.WriteLine($"{"ABC".GetType}"); // 출력: System.String

        Console.WriteLine($"{"ABC"[0].GetType}"); // 출력: System.Char

        Console.WriteLine($"{str[0]}");
    }
}