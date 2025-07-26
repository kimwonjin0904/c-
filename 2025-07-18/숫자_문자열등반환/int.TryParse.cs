using System;

public class int_TryParse
{

    public static void Main()
    {
        string input = "1234";
        if (int.TryParse(input, out int result))
        {
            Console.WriteLine(result); // 출력: 1234
        }
        else
        {
            Console.WriteLine("변환 실패");
        }



    }
}

