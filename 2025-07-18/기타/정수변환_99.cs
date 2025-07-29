using System;

public class 정수변환_99
{
    public static void Main()
    {
        // 정수 형식 변환하는 세 가지 방법

        // 1. Convert.ToInt32()
        string age = "26";
        int changeAge = Convert.ToInt32(age);
        Console.WriteLine(changeAge);
        Console.WriteLine($"{age} - {changeAge.GetType()}");
        Console.WriteLine("GetType(): {0}", changeAge.GetType());

        // 2. int.Parse()
        int age2 = int.Parse(age);
        Console.WriteLine($"{age2} - {age.GetType()}");

        // 3. int.TryParse()
        int age3;
        bool isParsed = int.TryParse(age, out age3);
        Console.WriteLine(isParsed ? $"성공: {age3}" : "실패");
    }
}
