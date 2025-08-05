using System;
using System.Text;

public class 논리연산자
{
    public static void Main()
    {
        //논리 연산자 
        //true && true  -> 둘다 참일때 참
        //true && false -> 하나라도 거짓이면 거짓

        //false || true  -> 하나라도 참이면 참
        //false || false -> 둘다 거짓일때 거짓

        Console.WriteLine($"true && true ->{true && true}");//둘다 참일때 참
        Console.WriteLine($"true && flase ->{true && false}");//하나라도 거짓이면 거짓
        Console.WriteLine($"true || true ->{true || true}");//둘중 하나만 참이면 참
        Console.WriteLine($"true && false ->{false || true}");//둘다 거짓일때 거짓
    }

}
