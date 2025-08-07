using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 조건처리
{
    public static void Main()
    {
        Console.Write("정수 입력:_\b"); //_\b는 입력 위치를 표시하기 위한 자리 표시자
        int a = Convert.ToInt32(Console.ReadLine());

        if (a % 2 == 0)//짝수라면
        {
            Console.WriteLine("짝수");
        }
        else
        {
            Console.WriteLine("홀수");
        }
    }
}