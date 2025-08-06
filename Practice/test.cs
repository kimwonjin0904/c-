using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 자리표시자
{
    public static void Main()
    {
        int number = 10;
        int number2= 20;

        if (number > number2)
        {
            Console.WriteLine($"number1이 더큼");
        }
        else if(number < number2)
        {
            Console.WriteLine("넘버2가 더 큼");
        }
        else
        {
            Console.WriteLine("에러임");
        }
    }
}