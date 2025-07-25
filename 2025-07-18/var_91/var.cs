using System;
public class var_91
{

    public static void Main()
    {
        //var은 데이터 형식을 파악하는 것
        var a = 20;
        Console.WriteLine("Type: {0}, value:{1}", a.GetType(), a);// Type: System.Int32, s:20

        var b = 3.14;
        Console.WriteLine("Type: {0}, value:{1}", b.GetType(), b);// Type: System.Double, s:3.14

        var c = "Hello, World!";
        Console.WriteLine("Type: {0}, value:{1}", c.GetType(), c);// Type: System.String, s:Hello, World!

        var d = new int[] { 10, 20, 30 };  //int[] d = {10,20,30}도 가능함
        Console.WriteLine("Type:{0},Value:", d.GetType());
        foreach (var e in d)
        {
            Console.WriteLine("{0}", e);

            Console.WriteLine();
        }
}

