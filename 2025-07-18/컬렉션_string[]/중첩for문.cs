using System;
using static System.Console;

public class 중첩for문
{
    static void Main()
    {
        // 2차원 배열 선언과 동시에 초기화하는 부분입니다.
        // new int[2, 3]는 '2행 3열'짜리 배열을 만들겠다는 뜻이고,
        // { {1, 2, 3}, {4, 5, 6} }은 그 안에 들어갈 값들을 지정합니다.
        int[,] intArray = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };


        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(i);
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"{intArray[i, j]}_");
            }
            Console.Write("\n");
        }
    }
}