using static System.Console;
using System.Text;

public class 낫연산자
{
    public static void Main()
    {
        //NOT 연산자

        bool bln = false;
        if (!bln)
        {
            Console.WriteLine($"{bln}그리고 {!bln}");//
        }
    }
}

