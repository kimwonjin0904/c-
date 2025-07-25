using System;

public class indexOf
{

    public static void Main()
    {
        string name = "김원진";
        int text = name.IndexOf("진"); // "김원진"에서 "원진"의 위치를 찾음 없으면 -1 반환
        Console.WriteLine(text);//

        //indexOf 문자열
        //string text = "hello";
        //int index1 = text.IndexOf("o");// "hello"에서 "o"의 위치를 찾음 없으면 -1 반환
        //Console.WriteLine(index1);// 4

        //var 
        string text2 = "hello";
        var var2 = text2.IndexOf("o");
        Console.WriteLine(var2);//4
        Console.WriteLine(text2);   // 출력: hello


        //형변환 
        int a = 3;
        float b = (float)a;
        Console.WriteLine(b);//



        //배열 사용 예시
        int[] numbers = { 10, 20, 30, 40 };
        int index = Array.IndexOf(numbers, 30); // → 2
        Console.WriteLine(index);

        //대소문자 구별
        // "Hello".IndexOf("h") -> -1  // "H"와 다르기 때문




    }
}

