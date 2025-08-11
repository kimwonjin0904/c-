using System;
using static System.Console;

public class 함수만들고호출
{
    static void ShowMessage(string message) //showmessage가 변수인가? string message가 매개변수인가?
    {
        Console.WriteLine(message);
    }
    static void Main()
    {
        ShowMessage("매개변수"); 
        ShowMessage("ParaMeter");
    }
   
}