using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using static System.Console;

public class nameof
{
    public static void Main()
    {
        int apple = 3;

        Console.WriteLine(nameof(System));
        Console.WriteLine(nameof(Console));
        Console.WriteLine(nameof(apple));

    }
}


