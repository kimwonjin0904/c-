using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 입력받은문자대소문자구별
{
    public static void Main()
    {
        Console.WriteLine("영문 대문자 또는 소문자 하나를 입력");
        char c = Convert.ToChar(Console.ReadLine());       //문자열을 char로 변환

        if (c >= 'A' && c <= 'Z')//대문자 범위 확인 (&& (논리 AND) 연산자&& 는그리고' 라는 뜻으로, 양쪽에 있는 두 조건이 모두 참(true)일 때만 if문 전체가 참)
        {
            Console.WriteLine($"{c}는 대문자");
        }
        else
        {
            Console.WriteLine($"{c}는 소문자");
        }
    }

}


