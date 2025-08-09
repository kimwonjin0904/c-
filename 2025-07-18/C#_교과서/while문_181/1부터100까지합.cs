using System;
using System.Diagnostics.CodeAnalysis;
using static System.Console;

public class while문_1부터100까지합
{
    public static void Main()
    {
        int i = 1;
        int sum = 0;

        while (i <= 100)
        {

            sum = sum + i;
            // WriteLine($"i: {i}, sum: {sum}");
            i++;
        }
        WriteLine(sum);
    }

}