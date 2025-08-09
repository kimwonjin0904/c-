using System;
using static System.Console;

public class 무한루프
{
    public static void Main()
    {
        int number = 0;

        while (true)
        {
            Console.WriteLine(++number);//++number는 number = number + 1;

            if (number >= 5)
            {
                break; // number가 5 이상이 되면 반복문을 빠져나감
            }

        }
    }

}