using System;
using System.Text;

public class 단항연산자
{
    public static void Main()
    {

        int value = 0;
        value = 8;
        value = +value;   // 단항 연산자 + (양수) 그대로 유지
        Console.WriteLine(value); // 출력: 8

        //실무에서는 그냥 int value = 8;로하긴 함

    }

}
