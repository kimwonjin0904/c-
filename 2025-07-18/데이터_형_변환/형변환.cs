using System;

public class 데이터_형_변환
{
    public static void Main()
    {



        sbyte a = 10;
        Console.WriteLine(a);

        object b = (object)a;    //sbyte를 object로 변환
        Console.WriteLine(b);

        int x = 140;
        Console.WriteLine(x);

        sbyte y = (sbyte)x;    //int를 sbyte로 변환
        Console.WriteLine(y);
        //sbyte는 -128 ~ 127까지의 범위만 허용하므로, 140은 변환할 수 없음
        //


        float d = 0.9f;
        int e = (int)d;
        Console.WriteLine(e); // 0

        float g = 1.1f;
        int h = (int)g;
        Console.WriteLine(h); //1
        Console.WriteLine(g);  //1.1
    }
}
