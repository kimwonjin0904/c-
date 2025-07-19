//C# 출력방식 연습
//object 변수 여러 방식으로 출력
//문자열 보간, 서식문자열, StringBuilder 등 비교

using static System.Console;

namespace _2025_07_18.출력방식
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = "Hello, World!";
            object b = 1234;
            object c = 'a';

            //출력 방법들

            // 1️.문자열 보간 
            //WriteLine($"a: {a}\nb: {b}\nc: {c}"); // 가독성 및 값 출력

            WriteLine($"{a}\n{b}");

            // 2️.서식 문자열 + 가변인자
            // WriteLine("a: {0}\nb: {1}\nc: {2}", a, b, c); 

            // 3️. + 연산 + 줄바꿈 직접 삽입
            // WriteLine(a + "\n" + b + "\n" + c); // 줄바꿈을 문자열로 추가

            // 4️. + 연산 + 설명 문자열 추가
            // WriteLine("a: " + a + "\nb: " + b + "\nc: " + c); // 설명까지 붙임

            // 5️.string.Concat 사용
            // WriteLine(string.Concat(a, "\n", b, "\n", c)); // 단순 문자열 결합

            // 6️.string.Join 사용
            // WriteLine(string.Join("\n", a, b, c)); // 구분자 기준으로 문자열 결합

            // 7. StringBuilder 사용 (대량 문자열 출력 시 유리)
            /*
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("a: " + a);
            sb.AppendLine("b: " + b);
            sb.AppendLine("c: " + c);
            WriteLine(sb.ToString());
            */
        }
    }
}