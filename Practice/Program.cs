using System;

public class Program
{
    public static void Main()
    {

        String op = "";
        int sum = 0;

        Console.Write("1 번째 숫자: ");
        int num1 =Convert.ToInt32(Console.ReadLine());

        Console.Write("연산자 입력:");
        op = Console.ReadLine();

        Console.Write("2 번째 숫자:");
        int num2 = Convert.ToInt32(Console.ReadLine());


        sum = num1 + num2;

        if (op == "+"){
            Console.WriteLine("더하기: " + num1 + " + " + num2 + " = " + (num1 + num2));
        }
        else if(op == "-")
        {
            Console.WriteLine("빼기" + num1 + "-" + num2 + "=" + (num1 - num2));
        }

    }
}
