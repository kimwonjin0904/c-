using System;

public class 자리표시자
{
    public static void Main()
    {
        //PadLeft();
        string s = "안녕";
        
        Console.Write($"{s.PadLeft(3,'0')}"); // "안녕"을 길이 3으로 맞추고 왼쪽에 '0'을 채움

    } 
    
}
