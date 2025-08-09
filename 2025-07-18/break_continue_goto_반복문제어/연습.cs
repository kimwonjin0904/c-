using System;
using static System.Console;

public class break_continue_goto_반복문제어
{
    public static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i >= 0)
            {
                Console.WriteLine("굳");
                // break; -> 굳1번
            }
        }
    }

}