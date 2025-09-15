using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using static System.Console;
enum Animal { Mouse, Cow, Tiger }
public class 열거형
{

    public static void Main()
    {
        Animal animal = Animal.Mouse;
        Console.WriteLine(animal);

        if (animal == Animal.Mouse)
        {
            Console.WriteLine("호랑이");
        }
        else
        {
            Console.WriteLine("호랑이 아님");
        }
    }
}
