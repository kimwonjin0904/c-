using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 좋아하는거선택
{
    public static void Main()
    {
        WriteLine("좋아하는 언어는:");
        Write("1.c  2.c++ 3.c# 4.java");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                WriteLine("C선택");
                break;

            case 2:
                WriteLine("C++선택");
                break;

            case 3:
                WriteLine("C#선택");
                break;

            case 4:
                WriteLine("java선택");
                break;
            default:
                WriteLine("잘못된 선택");
                break; //최종 case 레이블('default:')의 스위치에서 제어를 이동할 수 없습니다. break문 안 해서 오류
        }
    }

}


