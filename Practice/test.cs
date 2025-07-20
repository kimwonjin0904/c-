using System;

public class 자리표시자
{
    public static void Main()
    {

        int a = 10;
        float b = 12.3f;
        Console.WriteLine($"정수: {a}, 실수: {b}");

        string s = a.ToString(); // 문자열 "10"
        int x = int.Parse("123"); // 숫자 123

        Console.WriteLine(s);
        Console.WriteLine(x);




    }
}
