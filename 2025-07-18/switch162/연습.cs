using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 연습
{
    public static void Main()
    {
        Console.Write("정수입력:");
        int number = Convert.ToInt32(Console.ReadLine());


        switch (number)
        {
            case 1:
                Console.WriteLine("1");
                break;

            case 2:
                Console.WriteLine("2");
                break;


        }
        Console.WriteLine(number);




        //문자열
        Console.Write("문자를 입력하세요(y/n/c): ");
        char input = Convert.ToChar(Console.ReadLine());

        // input 변수는 char 타입이므로, case 값도 char 타입이어야 합니다.
        switch (input)
        {
            // 'y' 문자를 입력했을 때 실행
            case 'y':
                WriteLine("yes");
                break;

            // 'n' 문자를 입력했을 때 실행
            case 'n':
                WriteLine("no");
                break;

            // 'c' 문자를 입력했을 때 실행
            case 'c':
                WriteLine("cancel");
                break;

            // 'y', 'n', 'c'가 아닐 때 실행
            default:
                WriteLine("잘못된 입력입니다.");
                break;
        }
    }
}


