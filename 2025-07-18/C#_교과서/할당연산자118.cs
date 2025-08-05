using System;
using System.Text;

public class 값변경
{
    public static void Main()
    {
        var i = 100;
        var j = 200;

        var temp = i;     // temp는 100
        i = j;           // i는 200
        j = temp;       // j는 100

        Console.WriteLine($"i:{i}, j:{j}"); // 출력: i:200, j:100




    }

}
