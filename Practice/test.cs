using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Channels;
using static System.Console;

public class 정수형반환값사용
{
    static int Abs(int num)
    {
        return (num < 0) ? -num : num;
    }
    
    static void Main()
    {
        int num = -21;
        int abs = Abs(num); // Abs 함수 호출
        Console.WriteLine($"{num}의 절대값:{abs}");
    }
}

    
   
    



