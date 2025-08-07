using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 입력받은점수에따라상장부여
{
    public static void Main()
    {
        //입력 점수에 따른 상장 수여
        Console.Write("점수:");
        int score = Convert.ToInt32(Console.ReadLine());

        string grade = "";

        if (score >= 90)
        {
            grade = "금메달을 수상";
        }
        else if (score >= 80)
        {
            grade = "은 메달";
        }
        else
        {
            grade = "동메달";
        }
        Console.WriteLine(grade);
    }
}