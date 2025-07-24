using System;

public class Nullable_88
{

    public static void Main()
    {

        int? a = null; // Nullable<int> a = null;와 동일
        Console.WriteLine(a.HasValue);// false
        Console.WriteLine(a != null);  // false

        a = 3;
        Console.WriteLine(a.HasValue);//   true
        Console.WriteLine(a != null);// true
        Console.WriteLine(a.Value);// 3

    }
}

