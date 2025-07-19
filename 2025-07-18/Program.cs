using static System.Console;   //system만 Console.WriteLine()으로 사용 가능


namespace _2025_07_18
   
{
    internal class Program

    {

        static void Main(string[] args)
        {

            object a = "Hello, World!";
            object b = 1234;
            object c = 'a';

            //WriteLine(a+b);
            
            WriteLine(a + "\n" + b + "\n" + c);

        }
    }
}
