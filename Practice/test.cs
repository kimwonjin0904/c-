using System;

public class 자리표시자
{
    public static void Main()
    {
        //GetType() 메서드 사용
        int i = 1234;
        string s = "안녕";
        char c = 'A';

        Console.WriteLine($"i는{i.GetType()}");// int 형식
        Console.WriteLine($"s는{s.GetType()}");// string 형식
        Console.WriteLine(c.GetType);

    } 
    
}
