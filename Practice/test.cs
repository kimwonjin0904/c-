using System;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using static System.Console;


//열거형
enum Status : byte { Inactive =0,
                      Active = 1,
                      Pending = 2}

public class  EnumIndexChange
{
    static void Main()
    {
        Status curreuntStaus = Status.Active;  //열거형 변수 선언 currentStatus에 1 할당
        WriteLine($"현재상태: {curreuntStaus} {(int)curreuntStaus}");//출력: 현재상태: Active 1
        WriteLine((int)curreuntStaus);//출력: 1
    }
}
