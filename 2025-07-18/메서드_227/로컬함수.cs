using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ExceptionServices;
using static System.Console;

public class 로컬함수
{
    static void Main()
    {
        void Display(string text)   //Display 메서드 Main 메서드 안에 Display라는 새로운 메서드를 선언했습니다.
                                    //이 메서드는 text라는 문자열을 입력받아 어떤 행동(Console.WriteLine)을 수행
        {
            Console.WriteLine(text);
        }

        Display("안녕하세요");
    }
}