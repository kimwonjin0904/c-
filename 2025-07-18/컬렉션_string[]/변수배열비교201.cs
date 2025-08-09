using System;
using static System.Console;

public class ArrayAssignment
{
    public static void Main()
    {
        // 1. 크기가 3인 빈 정수 배열 선언 (초기 값은 모두 0)
        int[] numbers = new int[3];

        // 2. 인덱스를 사용해 값 하나씩 할당
        numbers[0] = 10; // 첫 번째 요소에 10 할당
        numbers[1] = 20; // 두 번째 요소에 20 할당
        numbers[2] = 30; // 세 번째 요소에 30 할당

        // 3. 할당된 값 확인
        WriteLine($"첫 번째 값: {numbers[0]}");
        WriteLine($"두 번째 값: {numbers[1]}");
        WriteLine($"세 번째 값: {numbers[2]}");

        // 4. foreach 루프로 모든 값 출력
        foreach (int num in numbers)
        {
            WriteLine(num);
        }
    }
}