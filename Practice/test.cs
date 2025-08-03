using System;

public class 자리표시자
{
    public static void Main()
    {
        var s = Console.ReadLine();
        var c = Convert.ToChar(Console.Read());
        Console.WriteLine($"s:{s},{s.GetType()} -- c:{c},{c.GetType()}");
    } 
    
}
