using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 배열
{
    public static void Main()
    {
        //var 방식 (타입 자동 추론)
        var array = new string[] { "Array", "List", "Dictionary" };
        //string[] array = { "Array", "List", "Dictionary" };

        foreach (var arr in array)   //array에 있는 요소들을 arr에 에 순차적으로 넣음    
        {
            Console.WriteLine(arr);
        }
        //string[]방식 (타입명시)
        string[] array2 = { "array2", "list2", "dictionary2" };

        foreach (string array3 in array2)
        {
            Console.WriteLine(array3);
        }
    }
}