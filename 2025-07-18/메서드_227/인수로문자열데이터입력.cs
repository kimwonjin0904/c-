using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using static System.Console;

public class 명령줄인수
{
    static void Main(string[] args)
    {

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
    }

}