using System;
using static System.Console;

public class 배열선언및초기화
{
    public static void Main()
    {
        int[] intArray = new int[3];
        intArray[0] = 1;
        intArray[1] = 2;
        intArray[2] = 3;

        Console.WriteLine("---- for 루프: 인덱스 1까지만 출력 ----");
        // i가 2보다 작을 때까지만 루프를 실행하도록 조건을 변경합니다.
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine($"{i}번째 인덱스:{intArray[i]}");
        }

        Console.WriteLine("\n---- foreach 루프: 모든 요소 출력 ----");
        // foreach 루프는 별개로 동작하며 모든 요소를 출력합니다.
        foreach (int intValue in intArray)
        {
            Console.WriteLine("{0}", intValue);
        }
    }
}