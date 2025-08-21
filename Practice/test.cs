using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using static System.Console;

public class 서로다른매개변수함수갖는오버로드
{
    static void Multi()
    {
        Console.WriteLine("안녕");
    }

    static void Multi(string message)
    {
        Console.WriteLine(message);
    }
    static void Multi(string message, int count)
    {
        for (int i =0; i < count; i++)
        {
            Console.WriteLine(message);
        }
    static void Main()
        {
        Multi(); // 매개변수 없는 함수 호출
        Multi("2번쨰"); // 문자열 매개변수 함수 호출
        Multi("3번쨰", 3); // 문자열과 정수 매개변수 함수 호출
        }
    }
}

