using static System.Console;
using System.Text;

public class out148
{
    public static void Main()
    {
        //헷갈렸던부분
        int r;
        if (int.TryParse("안녕", out r))
        {
            Console.WriteLine(r);//"안녕"int형으로 변환이 불가능하기에 이 코드느 실행x
        }

        if (int.TryParse("1234", out var result))
        {
            Console.WriteLine(result);// "1234"는 int형으로 변환이 가능하기에 이 코드는 실행됨
        }
        Console.WriteLine(result);
        // result는 if문 안에서 선언되었지만, out 키워드 덕분에 if문 밖에서도 사용 가능함
    }
}


