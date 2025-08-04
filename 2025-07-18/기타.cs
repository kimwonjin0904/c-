using System;
using System.Text;

public class 기타
{
    public static void Main()
    {
        //default로 형식 기본값 가져오기
        int intDefault = default(int);
        Console.WriteLine(intDefault);

        bool boolDefault = default(bool);
        Console.WriteLine(boolDefault);

        string stringDefault = default(string);
        Console.WriteLine(stringDefault);


        StringBuilder sbDefault = default(StringBuilder);
        Console.WriteLine(sbDefault);
    }

}
