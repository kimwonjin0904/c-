using System;

public class C_교과서_자리표시자_100
{
    public static void Main()
    {
        Console.Write("정수 입력:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        Console.WriteLine($"{number} - {number.GetType()}");


    }

}
