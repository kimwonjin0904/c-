using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 연습2
{
    public static void Main()
    {

        //1~100까지 더하기
        var sum = 0;


        for (var i = 1; i <= 100; i++)  //1~100까지 1씩증가
        {
            sum += i;  //sum = sum + i 즉 0+1 =1 이거를 1씩 증가 해서 0+1, 1+1,2+1이런식으로 100까지해서 다 더한값이 5050인건가?
        }
        Console.WriteLine(sum);


        //짝수만 더하기
        var sum2 = 0;
        for (var i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                sum2 += i;
            }

        }
        Console.WriteLine(sum2);
    }
}

