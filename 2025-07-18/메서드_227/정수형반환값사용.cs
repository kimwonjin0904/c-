using System;
using static System.Console;

public class 정수형반환값사용
{
    static int SquareFunction(int x)
    {
        int r = x * x;
        return r;
    }
    static void Main()
    {
        int r = SquareFunction(2);
        Console.WriteLine(r);
    }



}


