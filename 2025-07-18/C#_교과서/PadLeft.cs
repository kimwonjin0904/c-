using System;

public class PadLeft
{
    public static void Main()
    {
        //PadLeft();
        string s = "안녕";

        Console.Write($"{s.PadLeft(3, '0')}"); // "안녕"을 길이 3으로 맞추고 왼쪽에 '0'을 채움 
                                                //padLight이면 안녕000
                                                //''까먹지 말고 쓰기

    }

}
