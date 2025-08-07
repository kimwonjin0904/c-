using static System.Console;
using System.Text;

public class 두수에서큰수출력151
{
    public static void Main()
    {
        //두 수에서 큰 수 출력
        Console.WriteLine("첫 번째 수:");
        int first = Convert.ToInt32((Console.ReadLine())); //console.readline는 문자열을 입력받기 떄문에 Convert.ToInt32를 사용하여 정수로 변환
        Console.WriteLine("두 번째 수:");
        int second = Convert.ToInt32(Console.ReadLine());

        if (first >= second)
        {
            Console.WriteLine($"큰 값:{first}");
        }
        else
        {
            Console.WriteLine($"큰 값:{second}");
        }




        //두 수의 차이 출력
        int a = 3;
        int b = 5;
        int diff;

        if (a > b)
        {
            Console.WriteLine(diff = a - b);//출력값: 2
        }
        else
        {
            diff = b - a; //출력값: 2
        }
        Console.WriteLine($"{a}와 {b}의 차이:{diff}");
    }
}





