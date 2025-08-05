using static System.Console;
using System.Text;

public class 제어문
{
    public static void Main()
    {
        //if문 제어문
        int kor = 100;
        int eng = 90;

        int total;
        double avg;

        total = kor + eng;
        avg = total / 2.0;
        Console.WriteLine($"총점:{total}");
        Console.WriteLine($"평균:{avg}");




        //-------------------
        //score 가 60이상일떄 합격

        int score = 70;

        if (score >= 60)
        {
            Console.WriteLine("합격");
        }
        else
        {
            Console.WriteLine("불합격");
        }





        //===================================

        //if문 비교 연산자

        int x = 10;

        if (x == 10)
        {
            Console.WriteLine($"x는 {x}입니다");
        }
        if (x != 20)
        {
            Console.WriteLine($"x는 20이 아닙니다");
        }





        //====
        //if문 사용하여 문자열 비교
        string s1 = "Hello";
        string s2 = "Hello";

        Console.WriteLine(s1 == s2);

        if (s1 == s2)
        {
            Console.WriteLine("same");
        }
    }
}

