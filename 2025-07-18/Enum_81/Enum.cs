using System;

public class Enum
{
    enum DialogResult { Yes, NO, CANCEL, CONFIRM, OK }     //클래스 내부에서 실행 안됨
    public static void Main()
    {
        DialogResult result = DialogResult.Yes;


        //방법1:
        // Console.WriteLine((int)DialogResult.Yes);

        //방법2:
        Console.WriteLine(result);

        //Console.WriteLine(DialogResult); -> 열거형 타입이기떄문에 오류
        //DialogResult는 enum 타입     
        // result는 변수 이름
        //DialogResult.Yes는 enum 내에 정의된 값



    }
}

//enum DialogResult { Yes, NO, CANCEL, CONFIRM, OK }
//public static void Main()안에 입력할시 
//오류:
//1.}가 필요합니다.
//2.형식이나 네임스페이스 정의 또는 파일 끝(EOF)이 필요합니다.