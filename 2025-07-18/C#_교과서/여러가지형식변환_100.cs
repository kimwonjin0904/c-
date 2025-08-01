using System;

public class C_교과서_여러가지형식변환_100
{
    public static void Main()
    {
        Console.WriteLine("정수 입력:");
        string input = Console.ReadLine();
        int number = Convert.ToInt32(input);
        Console.WriteLine($"{number} - {number.GetType()}");




    }

}
