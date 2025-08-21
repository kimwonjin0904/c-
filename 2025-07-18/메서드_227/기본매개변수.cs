using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using static System.Console;

public class 기본매개변수
{



    static void Main()
    {
        Log("디버그");
        Log("에러", 4);
    }

    static void Log(string message, byte level = 1)
    {
        Console.WriteLine($"{message}, {level}");
    }
}







