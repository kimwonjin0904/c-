using System;
using System.Diagnostics.CodeAnalysis;
using System.Text;

public class 변환연산자
{
    public static void Main()
    {
        //변환 연산자:() 기호로 데이터 형식 변환
        int number = (int)3.14; //3.14를 정수로 변환하여 3을 저장
        Console.WriteLine(number); //출력: 3

        double number2 = (double)3.14;
        int number3 = (int)number2;
        Console.WriteLine(number2); //출력: 3.14
        Console.WriteLine(number3);//출력: 3


    }

}
