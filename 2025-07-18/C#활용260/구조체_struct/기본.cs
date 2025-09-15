using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using static System.Console;


struct Point
{
    public int X;   //pbulic 키워드로 외부에서 int X 변수를 사용하도록 설정
    public int Y;
}
public class 구조체
{
    public static void Main()
    {
        Point point; //Point 구조체 변수 point 선언
        point.X = 10; //point 구조체 변수의 X 멤버에 10 대입
        point.Y = 20; //point 구조체 변수의 Y 멤버에 20 대입
        Console.WriteLine($"X:{point.X} , Y: {point.Y}"); //출력값:X:10 , Y: 20
    }
}


