using System;

public class C
{
    public static void Main()
    {
        //숫자 -> 문자열 변경
        //convert.Tostring(변수);
        int i = 1234;
        string b = Convert.ToString(i);
        Console.WriteLine($"{b},{b.GetType()}");

    }

}
