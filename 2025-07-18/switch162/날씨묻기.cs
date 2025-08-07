using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 날씨묻기
{
    public static void Main()
    {
        Console.WriteLine("오늘 날씨는 어떤가요?(맑음,흐림,비,눈)");
        string weather = Console.ReadLine();  //문자열 이기 떄문에 변환 필요 없음

        switch (weather)
        {
            case "맑음":
                Console.WriteLine("오늘 날씨는 맑음");
                break;

            case "흐림":
                Console.WriteLine("오늘 날씨는 흐림");
                break;

            case "비":
                Console.WriteLine("오늘 날씨는 비");
                break;

            default:
                Console.WriteLine("눈이 오네요");
                break;

        }
    }

}


