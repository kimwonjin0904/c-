using System;
using static System.Console;

public class 반환값
{
    static string GetString()
    {
        return "반환값(RETURNVALUE)"; //return 키워드로 단순 문자열 반환
    }

    static void Main()
    {
        string returnValue = GetString(); // 함수 호출
        Console.WriteLine(returnValue); //반환값을 returnValue 변수에 저장하고 출력
    }
}


