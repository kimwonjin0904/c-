using static System.Console;
using System.Text;

public class NOT연산자
{
    public static void Main()
    {
        //not연산자
        // (1 == 1) -> true
        // (1 != 1) -> false
        //!(1 == 1) -> false
        //!(1 != 1) -> true

        var i = 3;
        var j = 5;
        var r = false;

        r = (i == 3) && (j != 3);// true && true -> true  ,i가 3이고 j가 3이 아니므로 true
        WriteLine(r);

        r = (i != 3) && (j != 3);// false && true -> false ,i가 3이므로 false
        WriteLine(r);

        r = (i < 5);   // true , i가 5보다 작으므로 true
        WriteLine(!r); // i가 5보다 작으므로 true, !r는 false

        Console.WriteLine(false && true);// false, 둘 중 하나라도 false이면 false
        Console.WriteLine((1 == 1) || (1 != 1)); // true, 둘 중 하나라도 true이면 true
        Console.WriteLine(!(1 == 1));// false, 1이 1과 같으므로 true, !true는 false


    }

}
