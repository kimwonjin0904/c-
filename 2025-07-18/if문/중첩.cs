using static System.Console;
using System.Text;

public class 중첩
{
    public static void Main()
    {
        //중첩
        int number = 1234;
        if (number == 1234 && number >= 1000) //둘다 참일 때
        {
            Console.WriteLine("맞음");
        }

        if (number == 1234 || number >= 1000) //둘 중 하나만 참일 때
        {
            Console.WriteLine("맞음");
        }

    }
}

