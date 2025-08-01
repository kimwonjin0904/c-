using System;

public class C_교과서_Convert_97
{
    public static void Main()
    {
        Console.Write("나이를 입력하세요: ");
        string input = Console.ReadLine();

        int age; 

        // TryParse를 사용해 입력된 문자열을 숫자로 변환을 시도
        if (int.TryParse(input, out age))
        {
            // 성공시 실행
            if (age > 0)
            {
                Console.WriteLine($"입력하신 나이는 {age}세 입니다.");
            }
            else
            {
                Console.WriteLine("오류: 나이는 0보다 커야 합니다.");
            }
        }
        else
        {
            // 변환에 실패했을 때 실행
            Console.WriteLine("오류: 올바른 숫자 형식으로 입력해주세요.");
        }
    }

}
