using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;


public class 사전
{
    public static void Main()
    {
        //명시적       
        Dictionary<int, string> dictionary = new Dictionary<int, string>
        {
            {0,"zero" },
            {1,"one" },
            {2,"tow" }
        };

        foreach (KeyValuePair<int, string> pair in dictionary)
        {
            Console.WriteLine($"{pair.Key} - {pair.Value}");
        }


        //var 방식 (타입 자동 추론)
        var dictionary2 = new Dictionary<int, string>
        {
            {0, "zero" },
            {1, "one" },
            {2, "two" }
        };
        foreach (var pair in dictionary2)
        {
            Console.WriteLine($"{pair.Key} -{pair.Value}");
        }

    }
}