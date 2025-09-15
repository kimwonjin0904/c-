using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using static System.Console;



public class 인라인out
{

    public static int Sum(int a, int b, out int result)
    {
        result = a + b;
        return result;


    }
    public static void Main()
    {

        Sum(3, 5, out int result);
        Console.WriteLine(result);


    }
}


