using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using static System.Console;

public class 화살표함수
{
    static void Main()
    {
        HI();
        Plus(3, 5);
    }

    static void HI() => Console.WriteLine("hi");
    static void Plus(int a, int b) => Console.WriteLine(a + b);



}