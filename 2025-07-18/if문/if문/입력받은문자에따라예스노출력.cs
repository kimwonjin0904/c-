using static System.Console;
using System.Text;
using System.Security.Cryptography;

public class 입력받은문자에따라예스노출력
{
    public static void Main()
    {

        //방법 1
        Console.Write("문자를 입력하세요(y/n/c)");
        char input = Convert.ToChar(Console.ReadLine());//문자열을 char로 변환

        if (input == 'y')
        {
            Console.WriteLine("yes");
        }
        else
        {
            if (input == 'n')
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine("cancel");
            }
        }
    }
}

//방법2
/*Console.Write("문자를 입력하세요(y/n/c)");
char input = Convert.ToChar(Console.ReadLine());//문자열을 char로 변환

if (input == 'y')
{
Console.WriteLIne("yes");
}
else if( input == 'n'){

{
Console.WriteLine("no");
}
else
{
Console.WriteLine("cancel");
}
{
*/
