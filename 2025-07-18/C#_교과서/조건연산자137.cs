using static System.Console;
using System.Text;

public class 조건연산자137
{
    public static void Main()
    {
        //조건 연산자
        //조건식 ? 식1: 식2;
        //조건식: (Number %2 ==0)
        //식1:"짝수"
        //식2:"홀수"

        int number = 3;

        string result = (number % 2 == 0) ? "짝수" : "홀수";
        // number가 2로 나누어 떨어지면 "짝수", 그렇지 않으면 "홀수"



        //조건 연산자 사용하여 최댓값 정하기
        const int max_size = 20;
        int pageSize = 10;
        pageSize = (pageSize > max_size) ? max_size : pageSize;
        // pageSie가 max_size보다 크면 max_size를, 그렇지 않으면 pageSie를 사용
        Console.WriteLine(pageSize);// 출력: 10


        //조건연산자 문자 비교
        string result2 = ""; //이거는 왜 쓰이는거지?

        result = ('a' < 'b') ? "a는 b보다 작음" : "a는 b보다 크거나 같음";// 'a'는 'b'보다 작으므로 참
        Console.WriteLine(result2);// 출력: a는 b보다 작음

    }

}
