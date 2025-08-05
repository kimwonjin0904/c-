using System;
using System.Text;

public class 숫자형식열변환
{
    public static void Main()
    {
        //숫자형식 -> 문자열로 변환
        int days = 28;
        Console.WriteLine($"2월은{days}입니다.");//문자열 보간법
        Console.WriteLine("2월은" + days.ToString() + "일입니다");//명시적 변환  숫자 형식-> 문자열 변환
        Console.WriteLine("2월은" + days + "일입니다");//암시적 변환 숫자 형식-> 문자열 변환
        Console.WriteLine("2월은" + Convert.ToString(days) + "일입니다.");//명시적 변환 숫자 형식-> 문자열 변환





    }

}
