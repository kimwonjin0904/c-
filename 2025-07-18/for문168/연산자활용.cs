using System;
using System.Security.Cryptography;
using System.Text;
using static System.Console;

public class 연산자활용
{
    public static void Main()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(i);// for문을 1~5까지 1씩 증가인데 여기에 출력값이 1,2,3,4,5

            // i가 3으로 나누어 떨어지면 줄바꿈
            if (i % 3 == 0)
            {
                Console.WriteLine();
                Console.WriteLine(i);//3
                Console.WriteLine(); // 3으로 나눠 떨어지면 줄바꿈
            }
        }
        Console.WriteLine(); //이거는 왜 쓴거지? 여기는 출력이 4,5인가?
    }
}