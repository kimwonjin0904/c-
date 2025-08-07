using System;
using System.Security.Cryptography;
using System.Text;
using static System.Console;

public class for문168
{
    public static void Main()
    {

        // 0부터 5까지의 짝수 합계를 구하기
        var sum = 0;

        // i를 0부터 5까지 1씩 증가시키며 반복
        for (var i = 0; i <= 5; i++)
        {
            // i를 2로 나눈 나머지가 0이면 짝수
            if (i % 2 == 0)
            {
                // 짝수(0, 2, 4)만 sum에 더하기
                sum += i;
            }
        }

        // 최종 합계인 6을 출력
        Console.WriteLine(sum);
    }
}

