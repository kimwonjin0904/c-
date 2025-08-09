using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;


public class 리스트
{
    public static void Main()
    {
        //리스트 var 방식 (타입 자동 추론)
        var list = new List<String> { "array", "list", "dictonary" };

        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
        //타입 명시
        List<string> list2 = new List<string> { "array5", "list5" };

        foreach (string lists in list2)
        {
            Console.WriteLine(lists);
        }


    }
}