using System;
using static System.Console;

public class 구구단
{
    public static void Main()
    {
        // 바깥 루프: 2단부터 9단까지 반복 (몇 단?)
        for (int i = 2; i <= 9; i++)
        {
            // 안쪽 루프: 각 단에서 1부터 9까지 곱하기 (얼마나 곱할까?)
            for (int j = 1; j <= 9; j++)
            {
                // i와 j를 곱한 결과를 출력
                WriteLine($"{i} * {j} = {i * j}");
            }
            // 한 단이 끝나면 빈 줄로 구분
            WriteLine();
        }
    }
}