using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class 빈배열
{
    public static void Main()
    {
        string[] authors = { "" };
        if (authors.Length == 0)
        {
            Console.WriteLine($"글쓴이가 {authors.Length}명 있습니다.");
        }
        else
        {
            Console.WriteLine($"글쓴이가 아무도 없습니다.");
        }
    }
}