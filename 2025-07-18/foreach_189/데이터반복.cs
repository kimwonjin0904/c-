using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 실행돌리는곳
{
    public static void Main()
    {
        string[] names = { "C#", "ASP.NET" };
        foreach (string name in names)
        {
            Console.WriteLine($"{name}\t"); // C#과 ASP.NET을 출력
        }
    }
}


