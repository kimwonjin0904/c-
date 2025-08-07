using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 성적판단
{
    public static void Main()
    {
        //성적 판단
        Console.Write("점수 입력:");
        int score = Convert.ToInt32(Console.ReadLine());

        string grade = ""; //성적을 저장할 변수

        if (score >= 90)
        {
            grade = "a";
        }
        else if (score >= 80)
        {
            grade = "b";
        }
        else
        {
            grade = "c";
        }
        Console.WriteLine(grade);

    }
}