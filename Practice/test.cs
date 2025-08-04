using System;
using System.Text;

public class 자리표시자
{
    public static void Main()
    {
        //튜플 리터럴
        var i = (100, 200);
        Console.Write(i.Item1);


        var (x, y) = (300, 400);
        Console.WriteLine($"{x},{y}");
    }
    //
    //오류:
    //'(int, int)'에는 'item1'에 대한 정의가 포함되어 있지 않고, '(int, int)' 형식의 첫 번째 인수를
    //허용하는 액세스 가능한 확장 메서드 'item1'이(가) 없습니다.
    //using 지시문 또는 어셈블리 참조가 있는지 확인하세요.
    //대소문자 오류

}
